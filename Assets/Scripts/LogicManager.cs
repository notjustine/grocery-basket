using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{

    //bool readOnce = false;

    public Text helpButton;
    string helpButtonOpen = "OK";
    string helpButtonClosed = "Help";

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
        //readOnce = true;

        if (panel.activeSelf == false)
        {
            panel.SetActive(true);
            helpButton.text = helpButtonOpen;
        }
        else if (panel.activeSelf == true)
        {
            panel.SetActive(false);
            helpButton.text = helpButtonClosed;
        } 

    }
}
