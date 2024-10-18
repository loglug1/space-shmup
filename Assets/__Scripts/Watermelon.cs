using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(BoundsCheck))]
public class Watermelon : ProjectileHero
{
    Weapon w;
    new void Awake() {
        base.Awake();
        w = GetComponentInChildren<Weapon>();
        w.type = eWeaponType.watermelonBits;
    }

    public override eWeaponType type {
        get { return eWeaponType.watermelon; }
        set { _type = eWeaponType.watermelon; }
    }

    void OnDestroy() {
        Debug.Log("Test");
        GameObject wGO = transform.GetChild(0).gameObject;
        wGO.transform.SetParent(transform.parent);
        w.Fire();
        Destroy(wGO, 1f);
    }
}
