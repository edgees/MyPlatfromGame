using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPos : MonoBehaviour
{
    playermovement _playermovement;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(player.transform.position.x, player.transform.position.y);
    }

}
