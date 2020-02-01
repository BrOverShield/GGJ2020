using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickableItem : MonoBehaviour
{

    //public GeneratorMap gm;
    //public ItemTypes thisItemType;
    public GameObject pickupAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  
    public virtual void thisItemEffect(GameObject player)
    {
        Debug.Log("unknown item picked");
    }
    private void Update()
    {
        //if (gm == null)
        //{
        //    gm = FindObjectOfType<GeneratorMap>();
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {

        
        GameObject collidedObject = collision.collider.gameObject;

        Debug.Log(collidedObject.tag);

        if (collidedObject.tag == "Player")
        {
            Destroy(this.gameObject);
            thisItemEffect(collidedObject);
            //if (gm == null)
            //{
            //    gm = FindObjectOfType<GeneratorMap>();
            //    print("wuuuuuuuuut");
            //}
            //AudioManager.Instance.ItemPickup.Play(transform.position);
            Instantiate(pickupAnim, this.transform.position, Quaternion.identity);
        }

    }

    // private void OnTriggerEnter(Collider col)
    //{
    //    GameObject collidedObject = col.gameObject;



    //    if (collidedObject.tag == "Player")
    //    {
    //        Destroy(this.gameObject);
    //        thisItemEffect(collidedObject);
    //        //if (gm == null)
    //        //{
    //        //    gm = FindObjectOfType<GeneratorMap>();
    //        //    print("wuuuuuuuuut");
    //        //}
    //        //AudioManager.Instance.ItemPickup.Play(transform.position);
    //        Instantiate(pickupAnim, this.transform.position, Quaternion.identity);
    //    }
    //}




}
