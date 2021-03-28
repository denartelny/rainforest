﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetGeneration : MonoBehaviour
{
    public GameObject[] myPrefabs;
    public Vector3 spawnValues;
    public int repetitions;
    void Start()
    {

        for (int i = 0; i < repetitions; i++)
        {
            GenerateAllObjectsFromPrefabs(myPrefabs);
        }

    }
    void GenerateAllObjectsFromPrefabs(GameObject[] aPrefabset)
    {
        for (int counter = 0; counter < myPrefabs.Length; counter++)
        {
            //307.25f z
            //103.9 x
            // 79.520f y
            Vector3 spawnPosition = new Vector3(103.9f + Random.Range(spawnValues.x, -spawnValues.x), aPrefabset[counter].transform.localPosition.y, 307.25f + Random.Range(spawnValues.z, -spawnValues.z));
            Instantiate(aPrefabset[counter], spawnPosition, new Quaternion());
        }
    }
}
