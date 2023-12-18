using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleP;
    private GameObject player;
    //private GameObject boxVariant;

    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("teleport");
        if (!collision.gameObject.CompareTag("Player"))
            return;

        if (collision.gameObject.CompareTag("Player"))
        { 
            collision.transform.position = new Vector3(teleP.position.x, teleP.position.y, 0);
            //Destroy(boxVariant);
            
        }
    }
}
