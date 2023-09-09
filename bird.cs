using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    public float jumpForce = 10.0f; // Kuşun zıplama kuvveti
    public float jumpForce2 = 10.0f; // Kuşun zıplama kuvveti

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "lav")
        {
            SceneManager.LoadScene(2);
        }

        if (collision.gameObject.tag == "zizip")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(3, jumpForce), ForceMode2D.Impulse); // Zıplama kuvveti uygula
        }
        if (collision.gameObject.tag == "zizip2")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(-3, jumpForce2), ForceMode2D.Impulse); // Zıplama kuvveti uygula
        }
    }

}
