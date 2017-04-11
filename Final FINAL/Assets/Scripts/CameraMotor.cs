<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour {

    private Transform lookAt;
    private Vector3 startOffset;
    private Vector3 moveVector;

	// Use this for initialization
	void Start () {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startOffset = transform.position - lookAt.position;
	}
	
	// Update is called once per frame
	void Update () {
        moveVector = lookAt.position + startOffset;

        //x 

        //y
        moveVector.y = Mathf.Clamp(moveVector.y,2,5);
        //z

        transform.position = moveVector;

		
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour {

    private Transform lookAt;
    private Vector3 startOffset;
    private Vector3 moveVector;

	// Use this for initialization
	void Start () {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startOffset = transform.position - lookAt.position;
	}
	
	// Update is called once per frame
	void Update () {
        moveVector = lookAt.position + startOffset;

        //x 

        //y
        moveVector.y = Mathf.Clamp(moveVector.y,2,5);
        //z

        transform.position = moveVector;

		
	}
}
>>>>>>> master
