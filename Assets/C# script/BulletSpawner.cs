using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    private RectTransform SpawnPos;
    public GameObject SpawnPrefeb;
    // Start is called before the first frame update
    void Start()
    {
       SpawnPos = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            GameObject.Instantiate(SpawnPrefeb, SpawnPos.position, SpawnPos.rotation);
        }
    }

}
