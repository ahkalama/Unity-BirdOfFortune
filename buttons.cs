using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void PlayButton() //PLAY BUTTON FONKSİYONU SAHNE 1 İ YÜKLER QUİT OYUNDAN ATAR 
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

     public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }

}
