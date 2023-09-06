using UnityEditor;
using UnityEngine;
public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float yatayhareket;
    Rigidbody2D rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
      // yatayhareket = Input.GetAxis("Horizontal");
      rb.velocity = new Vector2(yatayhareket * moveSpeed * Time.deltaTime, rb.velocity.y);
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
