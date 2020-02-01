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
            Destroy(obj.gameObject);
            GetComponent<Rigidbody>().useGravity = true;
        }
        
    }
}