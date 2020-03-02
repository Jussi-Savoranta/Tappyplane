using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public string menuLevel;
    public string arcadeLevel;
    public GameObject erasePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //scripts for menucanvas
    public void Pause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
    public void ExitFlight()
    {
        SceneManager.LoadScene(menuLevel);
    }
    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        SceneManager.LoadScene(arcadeLevel);
        Time.timeScale = 1;
    }
    public void ErasePanel()
    {
        erasePanel.SetActive(true);
    }
    public void BackToPause()
    {
        erasePanel.SetActive(false);
    }
}
