using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public int enemynum = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemynum <= -1)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("EnemySpawnTrigger"))
        {
            Debug.Log("Enemy spawned");
            GameObject.Instantiate(Enemy, transform.position, transform.rotation);
            enemynum = enemynum - 1;
        }

    }
}
