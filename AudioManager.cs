using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource compenentinden çekiyor
    public Button playPauseButton;

    private bool isPlaying = true;

    void Start()
    {
        playPauseButton.onClick.AddListener(TogglePlayPause);
    }

    void TogglePlayPause()
    {
        if (isPlaying)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play(); 
        }
        isPlaying = !isPlaying;
    }
}

// bu script butona bastığında müziği açıp kapaması için
