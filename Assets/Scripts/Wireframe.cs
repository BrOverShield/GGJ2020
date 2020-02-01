using UnityEngine;

public class Wireframe : MonoBehaviour
{
    bool enabled = true;
    
    //void Start() { //juste pour tester la fonction
    //    enable();
    //    Invoke("disable",3f);
    //}
    
    void enable()
    {
        enabled = true;
    }
    
        void disable()
    {
        enabled = false;
    }
    
    
    void OnPreRender()
    {
        GL.wireframe = enabled;
    }

    void OnPostRender()
    {
        GL.wireframe = false;
    }
} 
