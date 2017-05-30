using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;








public class GooglePlay_Scripts : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        PlayGamesPlatform.Activate();

    }



    public void Login()
    {
        Social.localUser.Authenticate((bool success) =>
       {

           if (success)
           {
               Debug.Log("you've logged in");
           }
           else
           {
               Debug.Log("you've  not logged in");
           }
       });
    }


    public void logout()
    {
        PlayGamesPlatform.Instance.SignOut();
    }

    public void achievement()
    {
        Social.ReportProgress("CgkI5ZPslvIMEAIQAQ", 100.0f, (bool success) =>
        {
            //acheievment unlocked

        });

    }
}

