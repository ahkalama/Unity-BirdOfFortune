using UnityEditor;
using UnityEngine;
public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float yatayhareket;
    Rigidbody2D rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>(); //rigidbody çekip rb ye atıyorsss
    }

    private void Update()
    {
      rb.velocity = new Vector2(yatayhareket * moveSpeed * Time.deltaTime, rb.velocity.y);
      // yatay harakete göre sağa sola gidiyor veya duruyor
    }

    public void sol()
    {
        yatayhareket = -1;
    }
    public void sag()
    {
        yatayhareket = 1;
    }
    public void dur()
    {
        yatayhareket = 0;
    }
}
