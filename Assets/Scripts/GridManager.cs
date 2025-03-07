using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// tutorial: https://youtu.be/kkAjpQAM-jE?si=R4LQl7K99fD3l8Ih

public class GridManager : MonoBehaviour
{
    Camera cam;
    private int activeTriggerCount = 0;

    private int level1Triggers = 8;
    private int level2Triggers = 14;

    public GameObject solvedPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (activeTriggerCount == level1Triggers)
            {
                GameObject[] heldObjects = GameObject.FindGameObjectsWithTag("Held");

                if (heldObjects.Length == 0)
                {
                    solvedPanel.SetActive(true);
                }
            }

        } 
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Debug.Log(activeTriggerCount);

            if (activeTriggerCount == level2Triggers)
            {
                GameObject[] heldObjects = GameObject.FindGameObjectsWithTag("Held");

                if (heldObjects.Length == 0)
                {
                    solvedPanel.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        activeTriggerCount++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        activeTriggerCount--;
    }
}
