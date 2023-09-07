using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    public float jumpForce = 10.0f; // Kuşun zıplama kuvveti

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "lav")
        {
            SceneManager.LoadScene(2);
        }

        if (collision.gameObject.tag == "zizip")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero; // Mevcut hızı sıfırla
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse); // Zıplama kuvveti uygula
        }
    }
}
