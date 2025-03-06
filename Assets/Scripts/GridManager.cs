using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// tutorial: https://youtu.be/kkAjpQAM-jE?si=R4LQl7K99fD3l8Ih

public class GridManager : MonoBehaviour
{
    public dragAndDropIt dragAndDrop;
    private int activeTriggerCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        dragAndDrop = GameObject.FindGameObjectWithTag("Ingredient").GetComponent<dragAndDropIt>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(dragAndDrop.holding);

        if (activeTriggerCount == 8)
        {
            Debug.Log("solved!");
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
