using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float score = 0f;
    public int scoreThreshold = 500;
    public int scoreMax = 9999;
    public float gameDuration = 30f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public HoverPointGenerator generator;

    private int nextThreshold = 500;
    private float elapsedTime = 0f;

    void Start()
    {
        scoreText.text = "Score: 0";
        timerText.text = "Time: " + gameDuration.ToString("F0");
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        float remainingTime = Mathf.Max(0f, gameDuration - elapsedTime);
        timerText.text = "Time: " + remainingTime.ToString("F0");

        if (remainingTime <= 0f)
        {
            EndGame();
        }
    }

    public void AddScorePerFrame(float amount)
    {
        if (score >= scoreMax) return;

        score += amount;
        score = Mathf.Min(score, scoreMax);
        scoreText.text = "Score: " + Mathf.FloorToInt(score);

        if (score >= nextThreshold)
        {
            generator.RespawnHoverPoint();
            nextThreshold += scoreThreshold;
        }
    }

    public void EndGame()
    {
        PlayerPrefs.SetFloat("LastScore", score);
        if (score > PlayerPrefs.GetFloat("HighScore", 0f))
        {
            PlayerPrefs.SetFloat("HighScore", score);
        }

        SceneManager.LoadScene("ResultScene");
    }
}

