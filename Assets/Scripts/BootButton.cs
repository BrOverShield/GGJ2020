using UnityEngine;


public class BootButton : MonoBehaviour
{
    void OnMouseDown()
    {
        Object.FindObjectOfType<Boot>().Release();
    }
}
