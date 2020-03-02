using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreText scoreText;
    public int score;
    public int highScore;
    //score  for progress mode
    public int progress;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        progress = PlayerPrefs.GetInt("Progress");
    }

    // Update is called once per frame
    void Update()
    {
        if (highScore < score)
        {
            AddHighScore();
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
    public void AddScore()
    {
        score++;
    }
    public void AddHighScore()
    {
        highScore++;
    }
    public void AddProgress()
    {
        progress++;
    }
    public void SaveProgress()
    {
        PlayerPrefs.SetInt("Progress", progress);
    }
}
