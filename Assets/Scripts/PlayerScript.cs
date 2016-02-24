using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public float speed;             //player speed
    private Vector2 movement;       //vector player move
    Rigidbody2D rigid;



	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //thong so di chuyen theo 2 truc 
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(speed * inputX, speed * inputY);

        //shooting
        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");

        if (shoot)
        {
            WeaponScript weapon = GetComponent<WeaponScript>();
            if (weapon != null)
            {
                weapon.Attack(false);
            }
        }
    }

    void FixedUpdate()
    {
        rigid.velocity = movement;
    }
}
