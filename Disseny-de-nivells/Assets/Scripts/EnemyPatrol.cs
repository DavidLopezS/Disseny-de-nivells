using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatsIsWall;
    private bool wallContacted;

    private bool notAtEdge;
    public Transform edgeCheck;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        wallContacted = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatsIsWall);

        notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatsIsWall);

        if (wallContacted || !notAtEdge)
            moveRight = !moveRight;

        if (moveRight) {

            transform.localScale = new Vector3(-1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        } else{

            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }


	}
}
