using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : spawner
{
    public spawner CurrentWeapon;
    public Transform GunPosition;


    protected bool _tryshoot = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
        HandleWeapon();
        WeaponTypes();
    }

    protected virtual void HandleInput()
    {

    }
    protected virtual void HandleWeapon()
    {
        if (CurrentWeapon == null)
            return;

        CurrentWeapon.transform.position = GunPosition.position;
        CurrentWeapon.transform.rotation = GunPosition.rotation;

        if (_tryshoot)
        {
            CurrentWeapon.Shoot();
        }

    }

    public void EquipWeapon(spawner weapon)
    {
        if (weapon == null)
        {
            return;
        }

        CurrentWeapon = weapon;
    }

    protected virtual void WeaponTypes()
    { }

}
