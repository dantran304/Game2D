using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
    public float speed;
    private Vector2 movement;
    private Vector2 direction;
    Rigidbody2D rigid;
	// Use this for initialization
	void Start () {
        direction = new Vector2(-1, 0);
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        movement = new Vector2(speed * direction.x, speed * direction.y);
	}

    void FixedUpdate()
    {
        rigid.velocity = movement;
    }
}
