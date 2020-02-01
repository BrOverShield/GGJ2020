using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDroper : MonoBehaviour
{
    public Image DropPoint;
    public GameObject schematicView;
    //if is drop over a drop point.
    //Destroy
    //Activate slot
    private void OnMouseUp()
    {
        if(schematicView.activeSelf==true)
        {
            if (Vector2.Distance(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(DropPoint.transform.position.x, DropPoint.transform.position.y)) <= 1)
            {
                DropPoint.color = Color.green;
                Destroy(this.gameObject);
            }
        }
        
    }
}
