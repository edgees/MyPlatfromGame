using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillBullet : MonoBehaviour
{
    private BulletRecorder _bullet;
    public int bulletamount = 1;

    private void Start()
    {
        GameObject targetBulletRecorder = GameObject.FindGameObjectWithTag("BulletRecorder");
        _bullet = targetBulletRecorder.GetComponent<BulletRecorder>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bullet Get");
        _bullet.GetBullet(bulletamount);
        Destroy(gameObject);
    }

}
