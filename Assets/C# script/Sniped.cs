using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniped : MonoBehaviour
{
    
    private BulletRecorder _bullet;
    private AudioSource DieAudioSource;
    private EnemyHealth _enemyHealth;
    public float Health = 1f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject targetBulletRecorder = GameObject.FindGameObjectWithTag("BulletRecorder");
        _bullet = targetBulletRecorder.GetComponent<BulletRecorder>();
        DieAudioSource = GetComponent<AudioSource>();
        _enemyHealth = GetComponent<EnemyHealth>();
    }
    void Update()
    {
        if (Health <= 0)
        {
            Health = 0;
            _enemyHealth.die();
        }
    }
    private void OnMouseOver()
    {

        if (_bullet.bullets <= 0)
            return;


        Debug.Log("try kill");

        if (Input.GetMouseButtonUp(1))
        {
            Health--;
        }


    }

}
