using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject pause;
    // Start is called before the first frame update

    public void showOptionPanel()
    {

        pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void Restart()
    {
        pause.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void Home()
    {
        pause.SetActive(false);
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }
}
