using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredTone : MonoBehaviour {

    public AudioClip tone;
    private AudioSource source;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            source.PlayOneShot(tone);
            
        }
        Debug.Log("Tone Played");
    }
}
