using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class HighScoreText : MonoBehaviour
{
    public Text highScoreText;
    //score for arcade mode
    public int highScore;
    //score  for progress mode
    public int progress;

    public Scene scene;
    private string mode2;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
        mode2 = "10 000 mode";
        progress = PlayerPrefs.GetInt("Progress");
    }

    // Update is called once per frame
    void Update()
    {
        if (scene.name == mode2)
        {
            progress = FindObjectOfType<GameManager>().progress;
            highScoreText.text = "Progress: " + progress.ToString();
        }
        else
        {
            highScore = FindObjectOfType<GameManager>().highScore;
            highScoreText.text = "Top Flight: " + highScore.ToString();
        }
      
    }
    
}
