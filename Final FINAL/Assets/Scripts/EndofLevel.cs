using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndofLevel : MonoBehaviour
{
    public string LevelTag;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt(LevelTag, 1);
            SceneManager.LoadScene("Level_Select");
        }
    }
}
