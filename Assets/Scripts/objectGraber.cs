using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectGraber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    private Vector3 mOffset;

    private float mZCoord;


    private void OnMouseDown()
    {
        Debug.Log("mouse down!");
        // mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        Debug.Log(mOffset);
    }


    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = this.gameObject.transform.position.z; 


        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    void OnMouseDrag()
    {
        // Debug.Log("dragging");

        this.gameObject.transform.position = GetMouseAsWorldPoint() + mOffset;

        //Debug.Log(Input.mousePosition);

    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
