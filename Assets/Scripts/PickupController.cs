using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.CompareTag("GravityArtefact"))
        {
            GetComponent<Rigidbody>().useGravity = true;
            Destroy(obj.gameObject);
        }
        
    }
}