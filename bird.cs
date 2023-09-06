using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "lav")
        {
             SceneManager.LoadScene(2);
        }
    }
}
