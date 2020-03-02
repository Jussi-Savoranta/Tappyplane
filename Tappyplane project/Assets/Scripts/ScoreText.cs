using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public Scene scene;
    private string mode1;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
        mode1 = "Level01";
    }

    // Update is called once per frame
    void Update()
    {
        if (scene.name == mode1)
        {
        score = FindObjectOfType<GameManager>().score;
        scoreText.text = "Score: " + score.ToString();
        }
          }
   
}
