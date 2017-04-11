<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerdSuccess : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerdSuccess : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
>>>>>>> master
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {



        }
        Debug.Log("Jumped Over Car");

<<<<<<< HEAD
    }
}
=======
    }
}
>>>>>>> master
