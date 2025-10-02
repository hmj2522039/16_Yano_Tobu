using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BorderTrigger : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager gm = FindObjectOfType<GameManager>();
            if (gm != null)
            {
                gm.EndGame(); // �X�R�A�ۑ����đJ��
            }
            else
            {
                SceneManager.LoadScene("ResultScene"); // �O�̂���
            }
        }
    }
}

