using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{


    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        print("YES");
        if (collision.gameObject.CompareTag("GravityArtefact"))
        {
            print("INSIDE");
        }
    }

    void Update()
    {
        
    }
}