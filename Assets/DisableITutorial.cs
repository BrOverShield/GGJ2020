using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableITutorial : MonoBehaviour
{
    public bool StillRelevant;

    public GameObject LeftImage;

    public Sprite NewImage1;
    public Sprite NewImage2;

    // Start is called before the first frame update
    void Start()
    {
        StillRelevant = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            if (StillRelevant)
            {
                StillRelevant = false;
                LeftImage.GetComponent<AnimateKey>().image1 = NewImage1;
                LeftImage.GetComponent<AnimateKey>().image2 = NewImage2;
            }
        }
    }
}
