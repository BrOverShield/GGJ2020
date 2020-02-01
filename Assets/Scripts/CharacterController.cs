using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (!(Input.GetKeyDown("d") && Input.GetKeyDown("a"))) {
            if (Input.GetKey("d")) {
                transform.Translate(Vector3.right * Speed * Time.deltaTime);
            } else if (Input.GetKey("a")) {
                transform.Translate(Vector3.left * Speed * Time.deltaTime);
            }
        }

        if (!(Input.GetKeyDown("q") && Input.GetKeyDown("e"))) {
            if (Input.GetKey("q")) {
                transform.Rotate(0, 1, 0);
            } else if (Input.GetKey("e")) {
                transform.Rotate(0, -1, 0);
            }
        }
    }
}
