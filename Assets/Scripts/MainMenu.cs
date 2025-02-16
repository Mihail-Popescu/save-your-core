using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public float Level1 = 0;
    public float Level2 = 0;
    public GameObject SetLevelActive;
    public GameObject SetLevelActive2;
    public void TestLevel()
    {
        Level1 = PlayerPrefs.GetFloat("level");
        Level2 = PlayerPrefs.GetFloat("level2");
        if (Level1 == 1)
        {
            //Debug.Log("it works!");
            SetLevelActive.SetActive(true);
        }
        if (Level2 == 2)
        {
            SetLevelActive2.SetActive(true);
        }
    } 

    public void DeleteAllData()
    {
        PlayerPrefs.SetFloat("level", 0);
        PlayerPrefs.SetFloat("level2", 0);
        SetLevelActive.SetActive(false);
        SetLevelActive2.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayGame2()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
