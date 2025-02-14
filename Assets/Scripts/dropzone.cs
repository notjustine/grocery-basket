using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropzone : MonoBehaviour
{

 void OnTriggerEnter2D(Collider2D col)
 	{
    col.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    col.gameObject.GetComponent<dragAndDropIt>().enabled = false;
	}
}
