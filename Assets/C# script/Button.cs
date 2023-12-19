using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour 
{
    public GameObject buttoninteractwith;
    public GameObject SoundEffect;
    private GameObject blocker;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("box"))
        {
            Debug.Log("Button Pressed");
            GameObject SE = GameObject.Instantiate(SoundEffect, transform.position, transform.rotation);
            Destroy(SE, 1f);
            Destroy(buttoninteractwith);
            Destroy(blocker);
            Destroy(gameObject);
        }
    }

}
