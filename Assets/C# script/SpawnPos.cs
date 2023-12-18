using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPos : MonoBehaviour
{
    public float RangeY = 0.2f;
    public float RangeX = 1;
    public float PositionY = 0.5f;
    public float PositionX = 0f;
    private playermovement _playermovement;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        _playermovement = GetComponent<playermovement>();
        transform.position = new Vector2(transform.position.x,transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("move forward");
            transform.position = new Vector2(transform.position.x + RangeX, transform.position.y - PositionY);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x - RangeX, transform.position.y + PositionY);
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("move backward");
            transform.position = new Vector2(transform.position.x - RangeX, transform.position.y - PositionY);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x + RangeX, transform.position.y + PositionY);
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
            transform.position = new Vector2(transform.position.x, transform.position.y - PositionY -RangeY);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + PositionY +RangeY);
        }
    }

}
