using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject exitPanel;
    public Button yesButton;
    public Button noButton;
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1); 
    }
    /*public void ShowExitPanel()
    {
        exitPanel.SetActive(false);
    }*/

    public void ShowExitPannel()
    {
        exitPanel.SetActive(false);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
