using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableADTutorial : MonoBehaviour
{
    public GameObject LeftImage;
    public GameObject RightImage;

    public Sprite NewImage1;
    public Sprite NewImage2;

    private bool stillRelevant;

    // Start is called before the first frame update
    void Start()
    {
        stillRelevant=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (stillRelevant)
        {
            RightImage.SetActive(false);

            LeftImage.GetComponent<AnimateKey>().image1 = NewImage1;
            LeftImage.GetComponent<AnimateKey>().image2 = NewImage2;

            stillRelevant = false;
        }
        
    }
}
