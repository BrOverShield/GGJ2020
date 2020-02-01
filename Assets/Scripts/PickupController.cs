using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public Camera TheCamera;

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
        if (obj.gameObject.CompareTag("WireframeArtefact"))
        {
            TheCamera.GetComponent<Wireframe>().disable();
            Destroy(obj.gameObject);
        }
        
    }
}