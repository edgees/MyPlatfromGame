using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Sniper : MonoBehaviour
{
    private BulletRecorder _bullet;
    private int CanShoot;
    public Text bullettext;
    // Start is called before the first frame update
    void Start()
    {
        _bullet = GetComponent<BulletRecorder>();
    }

    // Update is called once per frame
    void Update()
    {
        CanShoot = _bullet.bullets;
        bullettext.text = ("" + CanShoot); 
    }
    
}
