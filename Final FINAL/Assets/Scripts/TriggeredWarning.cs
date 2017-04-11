<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggeredWarning : MonoBehaviour {

    

    public AudioClip warning;
    private AudioSource source;
    public Text warningText;
    public float fadeSpeed = 5.0f;
    public bool carhorn;
    public GameObject LookOut;
    

  

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
        warningText = LookOut.GetComponentInChildren<Text>();
        warningText.color = Color.clear;
        

    }

  

    private void Update()
    {
        ColorChange();
        

    }

	
    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            source.PlayOneShot(warning);
            carhorn = true;
           
         
        }
        Debug.Log("Entered");
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            
            carhorn = false;
        }
        Debug.Log("Exited");
    }

    void ColorChange()
    {
        if(carhorn)
        {
            warningText.color = Color.Lerp(warningText.color, Color.magenta, fadeSpeed * Time.deltaTime);
        }

        if (!carhorn)
        {
            warningText.color = Color.Lerp(warningText.color, Color.clear, fadeSpeed * Time.deltaTime);
        }


    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggeredWarning : MonoBehaviour {

    

    public AudioClip warning;
    private AudioSource source;
    public Text warningText;
    public float fadeSpeed = 5.0f;
    public bool carhorn;
    public GameObject LookOut;
    

  

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
        warningText = LookOut.GetComponentInChildren<Text>();
        warningText.color = Color.clear;
        

    }

  

    private void Update()
    {
        ColorChange();
        

    }

	
    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            source.PlayOneShot(warning);
            carhorn = true;
           
         
        }
        Debug.Log("Entered");
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            
            carhorn = false;
        }
        Debug.Log("Exited");
    }

    void ColorChange()
    {
        if(carhorn)
        {
            warningText.color = Color.Lerp(warningText.color, Color.magenta, fadeSpeed * Time.deltaTime);
        }

        if (!carhorn)
        {
            warningText.color = Color.Lerp(warningText.color, Color.clear, fadeSpeed * Time.deltaTime);
        }


    }
}
>>>>>>> master
