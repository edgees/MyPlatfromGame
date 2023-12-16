using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRecorder : MonoBehaviour
{
    public int bullets = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (bullets <= 0)
            return;

        if (Input.GetMouseButtonUp(1))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        bullets--;
        if (bullets <= 0)
        {
             bullets = 0;
        }
    }

    public void GetBullet(int amount)
    {
        bullets = bullets + amount;
    }

}
