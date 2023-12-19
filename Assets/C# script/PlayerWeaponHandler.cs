using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponHandler : WeaponHandler
{
    public weapontypes CurrentWeapontype;
    private spawner _spawner;

    public enum weapontypes
    {
        //AutoFire,//=0 
        //BurstFire, //=1
        SingleFire //=2
    }

    private void Start()
    {
        _spawner = GetComponent<spawner>();
    }
    protected override void HandleInput()
    {


        //if (CurrentWeapontype == weapontypes.AutoFire)
        //{
        //    //Debug.Log("is autofire");
        //    //spawner.Interval = 0.15f;
        //    //if (Input.GetButton("Fire1"))
        //    //    _tryshoot = true;

        //    //if (Input.GetButtonUp("Fire1"))
        //    //    _tryshoot = false;
        //}

        //if (CurrentWeapontype == weapontypes.BurstFire)
        //{
        //    //Debug.Log("is burstfire");
        //    ////spawner.Interval = 0.1f;
        //    //int i = 0;
        //    //if (Input.GetButton("Fire1"))
        //    //{
        //    //    while (i < 3)
        //    //    {
        //    //        _tryshoot = true;

        //    //        i++;
        //    //        Debug.Log(i);

        //    //    }
        //    //}
        //    //if (i == 3)
        //    //{
        //    //    _tryshoot = false;
        //    //    i = 0;
        //    //    Debug.Log(i);
        //    //    return;
        //    //}
        //    //if (Input.GetButtonUp("Fire1"))
        //    //{
        //    //    _tryshoot = false;
        //    //}
        //}

        if (CurrentWeapontype == weapontypes.SingleFire)
        {
            
            spawner.Interval = 0.0000001f;
            if (Input.GetMouseButtonDown(0))
            {
                _spawner.CanSpawn = _spawner.CanSpawn - 1;
                _tryshoot = true;
                
            }

            if (Input.GetMouseButtonUp(0))
                _tryshoot = false;

            if (_spawner.CanSpawn <= 0) 
            {
                _tryshoot = false;
                _spawner.CanSpawn = 0;
            }

        }
    }

    protected override void WeaponTypes()
    {
        if (Input.GetButtonDown("Fire1"))
        { _tryshoot = true; }
        else
        { _tryshoot = false; }


    }


}