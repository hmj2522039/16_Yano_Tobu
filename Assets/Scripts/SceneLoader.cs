using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        Debug.Log("SceneLoader �N��");
    }

    public void LoadGameScene()
    {
        Debug.Log("�{�^�������ꂽ");

        SceneManager.LoadScene("GameScene");
    }

    public void LoadTitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }

}
