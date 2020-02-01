using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public bool RotateAxisUnlocked;
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

        if (!(Input.GetKeyDown("q") && Input.GetKeyDown("e")) && RotateAxisUnlocked) {
            if (Input.GetKeyDown("q")) {
                transform.Rotate(0, 90, 0);
            } else if (Input.GetKeyDown("e")) {
                transform.Rotate(0, -90, 0);
            }
        }
    }
}
