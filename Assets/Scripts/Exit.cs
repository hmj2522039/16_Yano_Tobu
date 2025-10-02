using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); // ビルド時にアプリを終了
            Debug.Log("ESCキーで終了"); // エディタではログ表示のみ
        }
    }
}
