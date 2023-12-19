using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private Sniped sniped;
    public GameObject DieSound;
    public enum enemytypes
    {
        normalenemy,
        tankenemy
    };
    public enemytypes enemytype;
    // Start is called before the first frame update
    void Start()
    {
        MoveSet();
    }

    // Update is called once per frame
    void Update()
    {
        if (DieSound == null)
            return;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            die();
        }
    }

    public void die()
    {
        Debug.Log("enemy dead");
        GameObject diedie = GameObject.Instantiate(DieSound, transform.position, transform.rotation);
        Destroy(diedie, 1f);
        Destroy(gameObject);
    }
    public void MoveSet()
    {
        switch (enemytype) 
        { 
            case enemytypes.normalenemy:
                {
                    Debug.Log("normalenemy");
                    break;
                }
            case enemytypes.tankenemy:
                {
                    Debug.Log("tankenemy");
                    break;
                }

        }
    }
}
