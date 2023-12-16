using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoxProjectile : MonoBehaviour
{
    private BulletRecorder _bullet;
    private spawner _spawner;
    public float Endurance = 1f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject targetBulletRecorder = GameObject.FindGameObjectWithTag("BulletRecorder");
        _bullet = targetBulletRecorder.GetComponent<BulletRecorder>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Endurance <= 0)
        {
            Endurance = 0;
            broke();
        }
    }

    private void OnMouseOver()
    {

        if (_bullet.bullets <= 0)
            return;


        

        if (Input.GetMouseButtonUp(1))
        {
            Endurance--;
            Debug.Log("try break");
        }


    }

    private void broke()
    {
        Destroy(gameObject);
    }
}
