using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string startLevel;
    public string menuLevel;
    public string otherMode;
    

    public GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //scripts for menucanvas
    public void NewGame()
    {
        SceneManager.LoadScene(startLevel);
        Time.timeScale = 1;
    }
    public void Load10000Mode()
    {
        SceneManager.LoadScene(otherMode);
        Time.timeScale = 1;

    }
}
