using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Someone collided");
        // Man kan ogs� RGB farver
        GetComponent<MeshRenderer>().material.color = Color.red;

        

    }



}
