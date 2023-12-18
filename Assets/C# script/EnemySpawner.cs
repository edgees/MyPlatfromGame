using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        if (Enemy == null)
            return;


        Debug.Log("Enemy spawned");
        GameObject.Instantiate(Enemy, transform.position, transform.rotation);
        Destroy(gameObject);
        


    }
}
