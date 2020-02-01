using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class features : MonoBehaviour
{

    public Camera TheCamera;
    public GameObject Character;
    public enum unlockableFeatures
    {
        wireframe,
        couleur,
        sound,
        twoPointFivey,
        twoPointFivex,
        twoPointFivez,
        Threed,
        Gravity
    }

    public List<unlockableFeatures> unlockedFeatures = new List<unlockableFeatures>();

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
    }

}
