using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectManager : MonoBehaviour {

    public string[] levelTags;

    public GameObject[] ticks;
    public bool[] levelCompleted;

	// Use this for initialization
	void Start () {

        for(int i = 0; i < levelTags.Length; i++)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if(PlayerPrefs.GetInt(levelTags[i]) == null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                levelCompleted[i] = false;
            }
            else if(PlayerPrefs.GetInt(levelTags[i]) == 0)
            {
                levelCompleted[i] = false;
            }
            else
            {
                levelCompleted[i] = true;
            }

            if(levelCompleted[i])
            {
                ticks[i].SetActive(true);
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
