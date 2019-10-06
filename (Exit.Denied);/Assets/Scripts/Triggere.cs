using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggere : MonoBehaviour
{
    [SerializeField]

    GameObject door;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Cube")
        { 
        door.transform.position += new Vector3(0, 4, 0);
        }
    }

        
    
}

