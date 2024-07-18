using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
