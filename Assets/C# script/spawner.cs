using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    float _timer = 0f;
    public static float Interval;
    bool _canShoot = true;
    public GameObject Projectile;
    public Transform SpawnPos;
    public int CanSpawn = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer < Interval)
        {
            _timer += Time.deltaTime;
            _canShoot = false;
            return;
        }
        _timer = 0;
        _canShoot = true;  
    }

    public void Shoot()
    {
        if(Projectile == null) 
        {
            Debug.LogWarning("Missing Projectile prefeb");
            return;
        }

        if (SpawnPos == null)
        {
            Debug.LogWarning("Missing SpawnPosition transform");
            return;
        }

        if (! _canShoot) 
        {
            return;
        }

        GameObject.Instantiate(Projectile, SpawnPos.position,SpawnPos.rotation);
    }

    public void GetBox(int amount)
    {
        CanSpawn = CanSpawn + amount;
    }

}
