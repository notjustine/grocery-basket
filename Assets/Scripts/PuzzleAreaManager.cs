using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleAreaManager : MonoBehaviour
{
    // Counter to track the number of active triggers
    private int activeItemCount = 0;

    void Update()
    {
        Debug.Log(activeItemCount);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Increment the trigger count when entering a trigger
        activeItemCount++;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Decrement the trigger count when exiting a trigger
        activeItemCount--;
    }
}
