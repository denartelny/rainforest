using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float rayDistance;
    public SimpleInventory inventory;
 
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "Mushroom")
                {
                    Debug.Log("Pickup");
                    Destroy(hit.collider.gameObject);
                    inventory.mushrooms++;
                }  
                
            }
        }
    }
}
