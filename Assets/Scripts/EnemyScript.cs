﻿using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
    private WeaponScript weapon;
	
    void Awake()
    {
        weapon = GetComponent<WeaponScript>();
    }
	
	// Update is called once per frame
	void Update () {
	if(weapon!=null && weapon.CanAttack)
        {
            weapon.Attack(true);
        }
	}
}
