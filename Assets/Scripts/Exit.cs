using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); // �r���h���ɃA�v�����I��
            Debug.Log("ESC�L�[�ŏI��"); // �G�f�B�^�ł̓��O�\���̂�
        }
    }
}
