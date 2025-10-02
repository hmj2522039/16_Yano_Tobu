using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    public TextMeshProUGUI resultScoreText;
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        float lastScore = PlayerPrefs.GetFloat("LastScore", 0f);
        float highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        resultScoreText.text = "Score: " + Mathf.FloorToInt(lastScore);
        highScoreText.text = "High Score: " + Mathf.FloorToInt(highScore);
    }

}
