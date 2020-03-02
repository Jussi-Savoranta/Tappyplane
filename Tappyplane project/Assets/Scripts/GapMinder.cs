using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GapMinder : MonoBehaviour
{
    public Scene scene;
    private string mode2;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        mode2 = "10 000 mode";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && scene.name == mode2)
        {
            FindObjectOfType<GameManager>().AddProgress();
            Debug.Log(FindObjectOfType<ScoreText>().score);
        }
        else if(collision.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().AddScore();
            Debug.Log(FindObjectOfType<ScoreText>().score);
        }
    }
}
