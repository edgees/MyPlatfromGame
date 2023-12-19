using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPos : MonoBehaviour
{
    public float RangeX = 0.2f;
    public float RangeY = 0.2f;
    private float PositionX = 0f;
    private float py = 0f;
    private Vector2 pos;
    public GameObject player;
    public Transform GunPosition;

    private void Start()
    {
        PositionX = RangeX;
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("move forward");
            transform.position = new Vector2(GunPosition.position.x, transform.position.y);
            py = transform.position.y;
            transform.position = new Vector2(GunPosition.position.x + PositionX, py);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position = new Vector2(GunPosition.position.x, transform.position.y);
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("move backward");
            transform.position = new Vector2(GunPosition.position.x, transform.position.y);
            py = transform.position.y;
            transform.position = new Vector2(GunPosition.position.x - PositionX, py);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            transform.position = new Vector2(GunPosition.position.x, transform.position.y);
        }

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    Debug.Log("move upward");
        //    transform.position = new Vector2(transform.position.x, transform.position.y);
        //}
        //else if (Input.GetKeyUp(KeyCode.D))
        //{
        //    transform.position = new Vector2(transform.position.x, transform.position.y);
        //}

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("move down");
            transform.position = new Vector2(GunPosition.position.x, GunPosition.position.y);
            py = transform.position.y - RangeY;
            transform.position = new Vector2(GunPosition.position.x, py);
            PositionX = 0;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position = new Vector2(GunPosition.position.x, GunPosition.position.y);
            PositionX = RangeX;
        }

        
    }

}
