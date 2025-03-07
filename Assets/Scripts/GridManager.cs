using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// tutorial: https://youtu.be/kkAjpQAM-jE?si=R4LQl7K99fD3l8Ih

public class GridManager : MonoBehaviour
{
    Camera cam;
    private int activeTriggerCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(cam.ScreenToWorldPoint(Input.mousePosition));

        if (activeTriggerCount == 8)
        {
            GameObject[] heldObjects = GameObject.FindGameObjectsWithTag("Held");

            if (heldObjects.Length == 0) 
            {
                Debug.Log("proceed to next level!");
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
