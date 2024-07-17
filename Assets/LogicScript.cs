using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreTOAdd)
    {
        playerScore = playerScore + scoreTOAdd;
        scoreText.text = playerScore.ToString();
    }
}
