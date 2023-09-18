using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text scoreDisplayText;      // Unity UI Text elemanı
    public Text higScoreDisplayText;   // Unity UI Text elemanı

    private void Start()
    {
        scoreDisplay();
        highscoreDisplay();
    }
    private void scoreDisplay()
    {
        scoreDisplayText.text = "Your Score: " + Timer.seconds; // Son scene de skorunu gösterir
    }

    private void highscoreDisplay()
    {
        higScoreDisplayText.text = "High Score: " + PlayerPrefs.GetInt("highscore").ToString();
    }
}
