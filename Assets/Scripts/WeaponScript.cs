using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

    ShotScript shot;
    public Transform shotPrefab;
    public float shootingRate = 0.25f;
    private float shootCooldown;
    MoveScript move;

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

    public void Attack(bool isEnemy)
    {
        if (CanAttack )
        {
            shootCooldown = shootingRate;
            Transform shotTranform = Instantiate(shotPrefab) as Transform;

            shotPrefab.position = gameObject.transform.position;
            move = shotTranform.gameObject.GetComponent<MoveScript>();
            if (shot != null)
            {
                shot.isEnemyShot = isEnemy;
            }

            move = shotTranform.gameObject.GetComponent<MoveScript>();

            if (move != null)
            {
                move.direction = this.transform.right;
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

