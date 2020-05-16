using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPlay : MonoBehaviour
{
    public GameObject HelpUI;

    public void Play()
    {
        SceneManager.LoadScene("_Complete-Game");
    }

    public void LoadHelp()
    {
        HelpUI.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
