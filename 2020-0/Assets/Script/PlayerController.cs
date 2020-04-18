using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;
    private bool doubleJump;
    private Vector3 scale;
    private bool grounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private float moveVelocity;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale;
    }

    private void FixedUpdate()
    {
        grounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, whatIsGround);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space)&& grounded)
        {
            Jump();
        }

        if (grounded)
        {
            doubleJump = false;
            animator.SetBool("isJumping", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && !grounded)
        {
            Jump();
            doubleJump = true;
        }

        moveVelocity = 0f;

        if (Input.GetKey(KeyCode.D))
        {
            moveVelocity = moveSpeed;
            animator.SetBool("isWalking", true);
        }

        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isWalking", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveVelocity = -moveSpeed;
            animator.SetBool("isWalking", true);
        }
        
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("isWalking", false);
        }

        if(Input.GetKeyDown(KeyCode.W) && grounded)
        {
            Jump();
        }

        if (GetComponent<Rigidbody>().velocity.x > 0)
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);


        else if (GetComponent<Rigidbody>().velocity.x < 0)

            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
        GetComponent<Rigidbody>().AddForce(new Vector3(moveVelocity,GetComponent<Rigidbody>().velocity.y,0));
    }

    void Jump()
    {
        GetComponent<Rigidbody>().velocity = new Vector2(GetComponent<Rigidbody>().velocity.x, jumpHeight);
    }
}
