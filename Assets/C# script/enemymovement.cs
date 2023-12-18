using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    private Transform player;
    public float movespeed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        player = GameObject.FindWithTag("Player").transform;

        transform.position = Vector2.MoveTowards(transform.position,player.transform.position,movespeed*Time.deltaTime);
    }

}
