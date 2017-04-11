using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredFail : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {

          

        }
        Debug.Log("Hit by Car");

    }
}
