using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumped_Car2 : MonoBehaviour {
    public static int result;


    // Use this for initialization
    void Start () {

    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            result = 2;


        }
        Debug.Log(result);


    }
}
