using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float liftForce = 0.2f; // �㏸��
    [SerializeField] public float moveForce = 0.5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))      // ��ړ�
        {
            rb.AddForce(Vector2.up * liftForce, ForceMode2D.Impulse);
        }
        if(Input.GetKey(KeyCode.RightArrow))    // �E�ړ�
        {
            rb.AddForce(Vector2.right * moveForce, ForceMode2D.Force);
        }
        if(Input.GetKey(KeyCode.LeftArrow))     // ���ړ�
        {
            rb.AddForce(Vector2.left * moveForce, ForceMode2D.Force);
        }
    }
}
