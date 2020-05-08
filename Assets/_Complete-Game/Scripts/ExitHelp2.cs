using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitHelp2 : MonoBehaviour
{
    public GameObject HelpUI;

    void Start()
    {
        HelpUI.SetActive(false);
    }

    public void Exit()
    {
        HelpUI.SetActive(false);
    }
}
