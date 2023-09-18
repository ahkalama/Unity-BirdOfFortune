using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText; // UI Text elemanı
    private float currentTime = 0f;
    public static int seconds;

    private void Update()
    {
        currentTime += Time.deltaTime;
        UpdateTimeText();

        if(seconds > PlayerPrefs.GetInt("highscore"))
            PlayerPrefs.SetInt("highscore", seconds);
    }

    private void UpdateTimeText()
    {
        seconds = Mathf.FloorToInt(currentTime);
        timeText.text = "Elapsed time: " + seconds.ToString(); // gecen süreyi söyler
    }
    
    
}
