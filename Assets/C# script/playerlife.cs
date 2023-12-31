using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerlife : MonoBehaviour
{

    private Animator anime;
    private Rigidbody2D rb2d;
    private BoxCollider2D bc2d;
    private enemymovement _enemymovement;
    private EnemyHealth enemyHealth;
    private playermovement _playermovement;
    public GameObject DieEffect;
    // Start is called before the first frame update
    private void Start()
    {
        anime = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
        enemyHealth = GetComponent<EnemyHealth>();
        _playermovement = GetComponent<playermovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap") || collision.gameObject.CompareTag("enemy"))
        {
            die();
        }
    }

    private void die()
    {
        GameObject diedie = GameObject.Instantiate(DieEffect, transform.position, transform.rotation);
        Destroy(diedie,1f);
        anime.SetTrigger("dead");
        rb2d.bodyType = RigidbodyType2D.Static;
        Destroy(bc2d);
    }

    private void restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
