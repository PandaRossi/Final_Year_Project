﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrigger5 : MonoBehaviour {

    public GameObject jeep;
   // public Animator anime;

    // Use this for initialization
    void Start()
    {
       // anime.enabled = false;

    }


    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {

            jeep.GetComponent<Animation>().Play("jeep5");

        }
        Debug.Log("Car5 Entered");
    }
}
