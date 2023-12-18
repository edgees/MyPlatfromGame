using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private Sniped sniped;
    private AudioSource DieAudioSource;
    public enum enemytypes
    {
        normalenemy,
        tankenemy
    };
    public enemytypes enemytype;
    // Start is called before the first frame update
    void Start()
    {
        DieAudioSource = GetComponent<AudioSource>();
        MoveSet();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            DieAudioSource.Play();
            die();
        }
    }

    public void die()
    {
        Debug.Log("enemy dead");
        
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
