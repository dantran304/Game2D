using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

    public Transform shotPrefab;
    public float shootingRate = 0.25f;
    private float shootCooldown;


	// Use this for initialization
	void Start () {
        shootCooldown = 0;
        shot = gameObject.GetComponent<ShotScript>();
    }

    // Update is called once per frame
    void Update() {
        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
        }

    public void Atcack(bool isEnemy)
    {
        if (CanAttack )
        {
            shootCooldown = shootingRate;
            Transform startTranform = Instantiate(shotPrefab) as Transform;

            


            shotPrefab.position = gameObject.transform.position;

            (if shot != null)
            {
                shot.isEnemyShot = isEnemy;
            }

        }
    }

    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }
    }
	}

