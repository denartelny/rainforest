using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//equireComponent(typeof (MeshFilter))]
public class MeshGenerator : MonoBehaviour
{
 public float heightScale    ;
 public float detailScale     ;
    private void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        for(int v = 0; v < vertices.Length; v++)
        {
            vertices[v].y = Mathf.PerlinNoise((vertices[v].x + this.transform.position.x) / detailScale, (vertices[v].z + this.gameObject.transform.position.z) / detailScale) * heightScale;
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
        this.gameObject.AddComponent<MeshCollider>();
    }
    private void Update()
    {
        
    }

}
