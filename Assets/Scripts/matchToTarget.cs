using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class matchToTarget : MonoBehaviour
{

	public TMP_Text _text;

    void OnTriggerEnter2D(Collider2D col)
    {
        Renderer renderer = GetComponent<Renderer>();
        if (col.CompareTag(gameObject.tag)) 
        {
        	renderer.material.color = new Color(255f, 0f, 216f);
            _text.text = "Nice";
            Debug.Log("Yes");
        }  
    }
    void OnTriggerExit2D(Collider2D col)
    {
        _text.text = " ";
    }
}