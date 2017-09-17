using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WeaponManager : NetworkBehaviour {

    [SerializeField] string WEAPON_LAYER_NAME = "Weapon";
    [SerializeField] PlayerWeapon primaryWeapon;
    [SerializeField] Transform weaponHolder;
    PlayerWeapon currentWeapon;

    void Start()
    {
        EquipWeapon(primaryWeapon);
    }

    void EquipWeapon(PlayerWeapon _weapon)
    {
        currentWeapon = _weapon;

        GameObject _weaponIns = Instantiate(_weapon.graphics, weaponHolder.position, weaponHolder.rotation);
        _weaponIns.transform.SetParent(weaponHolder);
        if(isLocalPlayer)
        {
            _weaponIns.layer = LayerMask.NameToLayer(WEAPON_LAYER_NAME);
        }
    }

    public PlayerWeapon GetCurrentWeapon()
    {
        return currentWeapon;
    }
}