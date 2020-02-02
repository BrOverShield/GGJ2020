using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class features : MonoBehaviour
{

    public Camera TheCamera;
    public GameObject Character;
    public GameObject RightImage;

    public Sprite NewImage1Jump;
    public Sprite NewImage2Jump;
    public enum unlockableFeatures
    {
        wireframe,
        couleur,
        sound,
        twoPointFivey,
        twoPointFivex,
        twoPointFivez,
        Threed,
        Gravity,
        Jump
    }



    public List<unlockableFeatures> unlockedFeatures;

    public void Awake()
    {
        unlockedFeatures = new List<unlockableFeatures>();
    }

    public void unlockFeature(unlockableFeatures featToUnlock)
    {
        if (!unlockedFeatures.Contains(featToUnlock))
        {
            unlockedFeatures.Add(featToUnlock);
           // Debug.Log("feature unlocked");
        }
    }

    public bool checkIfFeatureUnlocked(unlockableFeatures feature)
    {
        return unlockedFeatures.Contains(feature); 
    }

    void Update()
    {
        if (TheCamera.GetComponent<Wireframe>().enabled)
        {
            if (unlockedFeatures.Contains(unlockableFeatures.wireframe))
            {
                TheCamera.GetComponent<Wireframe>().Fixed = true;
            }
        }

        if (unlockedFeatures.Contains(unlockableFeatures.Gravity))
        {
            Character.GetComponent<Rigidbody>().useGravity = true;
        }

        if (unlockedFeatures.Contains(unlockableFeatures.Jump))
        {
            RightImage.GetComponent<AnimateKey>().image1 = NewImage1Jump;
            RightImage.GetComponent<AnimateKey>().image2 = NewImage2Jump;
            RightImage.SetActive(true);
            Character.GetComponent<PlayerController>().CanJump = true;
        }

        if (unlockedFeatures.Contains(unlockableFeatures.twoPointFivey))
        {
            Character.GetComponent<PlayerController>().RotateAxisUnlocked = true;
        }
    }

}
