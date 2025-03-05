using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// Script tutorial source "https://youtu.be/zY62cJk9i30?feature=shared"

public class dragAndDropIt : MonoBehaviour
{
    public delegate void DragEndedDelegate(Transform transform);
    public DragEndedDelegate dragEndedDelegate;
    Camera cam;
    Vector2 pos;
    bool holding;

    private int activeTriggerCount = 0;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (holding)
        {
            pos = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = pos;

            // Check for right mouse button click
            if (Input.GetMouseButtonDown(1))  // 1 represents right click
            {
                // Rotate 90 degrees around the Z axis
                transform.Rotate(0, 0, -90f);  // Negative for clockwise rotation
            }
        }
    }

    private void OnMouseDown()
    {
        if (activeTriggerCount == 0)
        {
            holding = !holding;
        }
        else
        {
            Debug.Log("Cannot Place!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Increment the trigger count when entering a trigger
        activeTriggerCount++;

        //Debug.Log($"Entered trigger with {other.gameObject.name}. Total active triggers: {activeTriggerCount}");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Decrement the trigger count when exiting a trigger
        activeTriggerCount--;

        //Debug.Log($"Exited trigger with {other.gameObject.name}. Total active triggers: {activeTriggerCount}");
    }

    //private void OnMouseUp()
    //{
    //    holding = false;
    //    //dragEndedDelegate(this.transform);
    //}

}
