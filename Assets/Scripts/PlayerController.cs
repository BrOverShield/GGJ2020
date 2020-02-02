﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;
    public float thrust = 1.0f;

    public float JumpThrust = 10.0f;
    public Rigidbody rb;

    public bool RotateAxisUnlocked;
    private bool Rotating_q = false;
    private bool Rotating_e = false;
    private int InitialAngle = 0;
    private float CurrentAngle;
    private int FinishAngle;
    private float Timer = 0;
    private features Feats;
    public features.unlockableFeatures twoPointFivey;

    public bool CanJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        CanJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            Timer += Time.deltaTime;
            if (Timer > 3) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
            }
        } else {
            Timer = 0;
        }

        Feats = FindObjectOfType<features>();
        if (!(Input.GetKeyDown("q") && Input.GetKeyDown("e")) && Feats.checkIfFeatureUnlocked(twoPointFivey) && !Rotating_q && !Rotating_e) {
            InitialAngle = (int)transform.eulerAngles.y;
            CurrentAngle = InitialAngle;
            if (Input.GetKeyDown("q")) {
                Rotating_q = true;
                FinishAngle = InitialAngle + 90;
                if (FinishAngle >= 360) {
                    FinishAngle -= 360;
                }
            } else if (Input.GetKeyDown("e")) {
                Rotating_e = true;
                FinishAngle = InitialAngle - 90;
                if (FinishAngle < 0) {
                    FinishAngle += 360;
                }
            }
        }

        if (Rotating_q) {
            transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);
            CurrentAngle = transform.eulerAngles.y;
            if ((FinishAngle == 0 && (int)CurrentAngle == 0) || (FinishAngle != 0 && CurrentAngle > FinishAngle)) {
                Rotating_q = false;
                transform.rotation = Quaternion.Euler(new Vector3(0, InitialAngle + 90, 0));
            }
        } else if (Rotating_e) {
            transform.Rotate(0, -(RotationSpeed * Time.deltaTime), 0);
            CurrentAngle = transform.eulerAngles.y;
            if ((FinishAngle == 0 && (int)CurrentAngle == 0) || (FinishAngle != 0 && CurrentAngle < FinishAngle)) {
                Rotating_e = false;
                transform.rotation = Quaternion.Euler(new Vector3(0, InitialAngle - 90, 0));
            }
        }
    }

    void FixedUpdate() {
        if (!(Input.GetKeyDown("d") && Input.GetKeyDown("a"))) {
            if (Input.GetKey("d")) {
                transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
                rb.AddForce(Vector3.right * thrust);
            } else if (Input.GetKey("a")) {
                transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
                rb.AddForce(Vector3.left * thrust);
            }
        } else {
            rb.velocity = new Vector3(0.0f, rb.velocity.y, 0.0f);   
        }
        if (Input.GetKeyDown("space"))
        {
            if (CanJump)
            {
                rb.AddForce(Vector3.up * JumpThrust);
            }
        }
    }
}

