using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public GameObject panel;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void resetPuzzle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void backToStart()
    {
        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void panelActive()
    {
        if (panel.activeSelf == false)
        {
            panel.SetActive(true);
        }
        else if (panel.activeSelf == true)
        {
            panel.SetActive(false);
        } 

    }
}
