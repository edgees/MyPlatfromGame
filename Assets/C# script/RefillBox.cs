using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillBox : MonoBehaviour
{
    private spawner playerWeaponHandler;
    public int boxamount = 1;

    private void Start()
    {
        GameObject target = GameObject.FindGameObjectWithTag("BoxRecorder");
        playerWeaponHandler = target.GetComponent<spawner>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Box Get");
        playerWeaponHandler.GetBox(boxamount);
        Destroy(gameObject);
    }
}
