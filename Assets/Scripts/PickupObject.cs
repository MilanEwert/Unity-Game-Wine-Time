﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public Transform theDest;

    void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("PickupDestination").transform;
        SoundManagerScript.PlaySound("pickup");
    }

    void OnMouseUp()
    {
        GetComponent<BoxCollider>().enabled = true;
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        SoundManagerScript.PlaySound("drop");
    }
    /*
    
    bool colliding;
 
    private void OnTriggerEnter(Collider other) {
        colliding = true;
    }
    private void OnTriggerExit(Collider other) {
        colliding = false;
    }
 
    private void Update() {
        if(colliding) {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("PickupDestination").transform;
            SoundManagerScript.PlaySound("pickup");
        }
    }
    */
    
}