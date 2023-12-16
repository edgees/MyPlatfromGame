using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour 
{
    public GameObject buttoninteractwith;
    private GameObject blocker;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("box"))
        {
            Debug.Log("Button Pressed");
            Destroy(buttoninteractwith);
            Destroy(blocker);
            Destroy(gameObject);
        }
    }

}
