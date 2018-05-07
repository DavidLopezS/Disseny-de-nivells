using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatsIsGround;
    private bool grounded;

    private bool doubleJumped;

    private Rigidbody2D myRigidBody2D;

    public bool onStairs;
    public float climbSpeed;
    private float climbVelocity;
    private float gravityStore;

	// Use this for initialization
	void Start () {
        myRigidBody2D = GetComponent<Rigidbody2D>();

        gravityStore = myRigidBody2D.gravityScale;
	}
	
    void FixedUpdate() {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatsIsGround);

    }

	// Update is called once per frame
	void Update () {

        if (grounded)
            doubleJumped = false;

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();            
        }if (Input.GetKeyDown(KeyCode.Space) && !doubleJumped && !grounded)
        {
            Jump();
            doubleJumped = true;
        }if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (onStairs)
        {
            myRigidBody2D.gravityScale = 0f;

            climbVelocity = climbSpeed * Input.GetAxisRaw("Vertical");

            myRigidBody2D.velocity = new Vector2(myRigidBody2D.velocity.x, climbVelocity);
        }

        if (!onStairs)
        {
            myRigidBody2D.gravityScale = gravityStore;
        }
    }

    public void Jump(){

        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.transform.tag == "MovingPlatform")
        {
            transform.parent = other.transform;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }
}
