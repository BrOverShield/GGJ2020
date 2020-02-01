using UnityEngine;

public class Wireframe : MonoBehaviour
{
    public bool activated;
    private float time;
    private float randomTime;

    public float MaxTime;

    public bool Fixed;
    
    //void Start() { //juste pour tester la fonction
    //    enable();
    //    Invoke("disable",3f);
    //}
    
    public void enable()
    {
        Fixed = true;
    }
    
    public void disable()
    {
        Fixed = false;
    }
    
    
    void OnPreRender()
    {
        GL.wireframe = activated;
    }

    void OnPostRender()
    {
        GL.wireframe = false;
    }
    void Start()
    {
        activated = false;
        Fixed = false;
        randomTime = Random.value * MaxTime;
    }

    void Update()
    {
        if (!Fixed)
        {
            if (activated)
            {
                disable();
            }
            else
            {
                time += Time.deltaTime;
                if (time > randomTime)
                {
                    time = 0;
                    randomTime = Random.value * MaxTime;
                    enable();
                }
            }
            
        }
        
    }
} 
