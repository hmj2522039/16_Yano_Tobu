using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverPoint : MonoBehaviour
{
    public float scoreSpeed = 100f; // 1�b�Ԃɉ��|�C���g���Z���邩
    private bool playerInside = false;

    void Update()
    {
        if (playerInside)
        {
            FindObjectOfType<GameManager>().AddScorePerFrame(scoreSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
        }
    }

}
