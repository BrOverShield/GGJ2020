using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float thrust = 1.0f;

    public float JumpThrust = 10.0f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

        if (!(Input.GetKeyDown("q") && Input.GetKeyDown("e")) && RotateAxisUnlocked) {
            if (Input.GetKeyDown("q")) {
                transform.Rotate(0, 90, 0);
            } else if (Input.GetKeyDown("e")) {
                transform.Rotate(0, -90, 0);
            }
        }
    }

    void FixedUpdate()
    {
        if (!(Input.GetKeyDown("d") && Input.GetKeyDown("a"))) {
            if (Input.GetKey("d")) {
                transform.Translate(Vector3.right * Speed * Time.deltaTime);
                rb.AddForce(Vector3.right * thrust);
            } else if (Input.GetKey("a")) {
                transform.Translate(Vector3.left * Speed * Time.deltaTime);
                rb.AddForce(Vector3.left * thrust);
            }
        }
        print(rb.velocity.y);
        if (Input.GetKeyDown("space") && Mathf.Abs(rb.velocity.y) < 0.5f)
        {
            print("yeah");
            rb.AddForce(Vector3.up * JumpThrust);
        }
    }
}
