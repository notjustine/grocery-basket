using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script tutorial source "https://youtu.be/zY62cJk9i30?feature=shared"

public class dragAndDropIt : MonoBehaviour
{
    public delegate void DragEndedDelegate(Transform transform);
    public DragEndedDelegate dragEndedDelegate;
    Camera cam;
    Vector2 pos;
    bool holding;

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
        }
    }

    private void OnMouseDown()
    {
        holding = true;
    }

    private void OnMouseUp()
    {
        holding = false;
        dragEndedDelegate(this.transform);
    }
    
}
