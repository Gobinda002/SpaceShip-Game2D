using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text highScoreText;
    public int highScore;
    public GameObject gameOverScreen;
    public AudioSource song;
   
    private bool isGameOver;




    [ContextMenu("Increase Score")]




    public void Start()
    {
        if (PlayerPrefs.HasKey("High Score"))
        {
            highScore = PlayerPrefs.GetInt("High Score");
            highScoreText.text = "High Score: " + highScore.ToString();
        }
    }
    public void addScore(int scoreTOAdd)
    {
        if(!isGameOver)
        {
            playerScore = playerScore + scoreTOAdd;
            scoreText.text = playerScore.ToString();
            
        }
       
    }
    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void gameOver()
    {
        isGameOver = true;
        gameOverScreen.SetActive(true);

        if (playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("High Score", playerScore);
            highScoreText.text = "High Score: " + highScore.ToString();
        }
       

    }

}

