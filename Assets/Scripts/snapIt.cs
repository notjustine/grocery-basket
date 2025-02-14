using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapIt : MonoBehaviour
{
    public List<Transform> snapPoints;
    public List<dragAndDropIt> dragScripts;
    public float snapRange = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
    	foreach(dragAndDropIt script in dragScripts)
    	{
    		script.dragEndedDelegate = SnapThings;
    	}
        
    }

    // Update is called once per frame
    public void SnapThings(Transform obj)
    {
        foreach (Transform point in snapPoints)
        {
        	if (Vector2.Distance(point.position, obj.position) <= snapRange)
        	{
        		obj.position = point.position;
        		return;
        	}
        }
    }
}
