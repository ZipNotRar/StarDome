using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.collider.tag == "Wall"); 
    }

    void OnCollisionStay(Collision col)
    {
        if(col.collider.tag == "Wall")
        {
            col.collider.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
    }
}
