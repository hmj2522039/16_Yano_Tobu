using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float liftForce = 0.2f; // è„è∏óÕ
    [SerializeField] public float moveForce = 0.5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))      // è„à⁄ìÆ
        {
            rb.AddForce(Vector2.up * liftForce, ForceMode2D.Impulse);
        }
        if(Input.GetKey(KeyCode.RightArrow))    // âEà⁄ìÆ
        {
            rb.AddForce(Vector2.right * moveForce, ForceMode2D.Force);
        }
        if(Input.GetKey(KeyCode.LeftArrow))     // ç∂à⁄ìÆ
        {
            rb.AddForce(Vector2.left * moveForce, ForceMode2D.Force);
        }
    }
}
