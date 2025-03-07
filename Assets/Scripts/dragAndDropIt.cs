using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// Script tutorial source "https://youtu.be/zY62cJk9i30?feature=shared"

public class dragAndDropIt : MonoBehaviour
{

    Camera cam;
    Vector2 pos;
    bool holding;

    int activeTriggerCount = 0;

    Vector3 heldScale;
    float zOriginal;

    public GameObject xMark;

    void Start()
    {
        cam = Camera.main;

        zOriginal = transform.position.z;

        heldScale = transform.localScale;
        transform.localScale *= 0.95f;
    }

    void Update()
    {

        if (holding)
        {
            gameObject.tag = "Held";

            pos = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3((float)pos.x, (float)pos.y, -1f);

            xMark.transform.position = new Vector3((float)pos.x, (float)pos.y, -2f);

            // Check for right mouse button click
            if (Input.GetMouseButtonDown(1))  // 1 represents right click
            {
                // Rotate 90 degrees around the Z axis
                transform.Rotate(0, 0, -90f);  // Negative for clockwise rotation
            }
        } 
        else
        {
            gameObject.tag = "Placed";

            Vector3 placedPosition = transform.position;
            placedPosition.z = zOriginal;

            transform.position = placedPosition;
        }
    }

    private void OnMouseDown()
    {
        if (activeTriggerCount == 0)
        {
            holding = !holding;
            changeSize();
        }
        else
        {
            Debug.Log("Cannot Place!");
            xMark.SetActive(true);
             
            Invoke("hideX", 0.3f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ingredient"))
        {
            activeTriggerCount++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.layer == LayerMask.NameToLayer("Ingredient"))
        {
            activeTriggerCount--;
        }
    }

    private void changeSize()
    {
        if (holding)
        {
            transform.localScale = heldScale;
        }
        else
        {
            transform.localScale *= 0.95f;
        }
    }

    private void hideX()
    {
        xMark.SetActive(false);
    }

}
