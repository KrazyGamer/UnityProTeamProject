using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject CreditsPanel;

    // Start is called before the first frame update
    void Start()
    {
        MainPanel.SetActive(true);
        CreditsPanel.SetActive(false);
    }

    //credits open
    public void OpenCredits()
    {
        CreditsPanel.SetActive(true);
        MainPanel.SetActive(false);
    }

    //credits close
    public void CloseCredits()
    {
        CreditsPanel.SetActive(false);
        MainPanel.SetActive(true);
    }

    public void switchLevel(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }

}