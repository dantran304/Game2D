using UnityEngine;
using System.Collections;


public class EnemyScript : MonoBehaviour {
    private bool hasSpawn;
    private WeaponScript[] weapons;
    private MoveScript moveScript;
	
    void Awake()
    {
        weapons = GetComponentsInChildren<WeaponScript>();
        moveScript = GetComponent<MoveScript>();
    }
	
    void Start()
    {
        hasSpawn = false;

        gameObject.GetComponent<Collider2D>().enabled = false;
        moveScript.enabled = false;

        foreach(WeaponScript weapon in weapons)
        {
            weapon.enabled = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (hasSpawn == false)
        {
            if (GetComponent<Renderer>().isVisibleFrom(Camera.main))
            {
                Spawn();
            }
        }
        else
        {


            foreach (WeaponScript weapon in weapons)
            {
                if (weapon != null && weapon.enabled && weapon.CanAttack)
                {
                    weapon.Attack(true);
                }
            }

            if (GetComponent<Renderer>().isVisibleFrom(Camera.main) == false)
            {
                Destroy(gameObject);
            }
        }
    }

    private void Spawn()
    {
        hasSpawn = true;

        gameObject.GetComponent<CircleCollider2D>().enabled = true;
        moveScript.enabled = true;

        foreach(WeaponScript weapon in weapons)
        {
            weapon.enabled = true;
        }
    }
}
