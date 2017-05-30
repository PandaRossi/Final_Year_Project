using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Levels : MonoBehaviour {

    public bool infoOpen = false;
    public Canvas infoCanvas;

    public void Level_1R()
    {
        SceneManager.LoadScene("Level_1R");
    }

    public void Level_1L()
    {
        SceneManager.LoadScene("Level_1L");
    }

    public void Level_2R()
    {
        SceneManager.LoadScene("Level_2R");
    }

    public void Level_2L()
    {
        SceneManager.LoadScene("Level_2L");
    }

    public void Level_3R()
    {
        SceneManager.LoadScene("Level_3R");
    }

    public void Level_3L()
    {
        SceneManager.LoadScene("Level_3L");
    }

    public void Level_4R()
    {
        SceneManager.LoadScene("Level_4R");
    }

    public void Level_4L()
    {
        SceneManager.LoadScene("Level_4L");
    }

    public void Level_5R()
    {
        SceneManager.LoadScene("Level_5R");
    }

    public void Level_5L()
    {
        SceneManager.LoadScene("Level_5L");
    }

    public void Level_6R()
    {
        SceneManager.LoadScene("Level_6R");
    }

    public void Level_6L()
    {
        SceneManager.LoadScene("Level_6L");
    }

    public void START_GAME()
    {
        SceneManager.LoadScene("Level_Select");
    }

    public void Main_Menu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void infoPanel()
    {
        if(infoOpen == false)
        {
            infoOpen = true;
            infoCanvas.enabled = true;
        }

        else if(infoOpen == true)
        {
            infoOpen = false;
            infoCanvas.enabled = false;
        }
    }

    public void Link()
    {
        Application.OpenURL("http://www.firstyears.org/lib/howtoread.htm");
    }

}
