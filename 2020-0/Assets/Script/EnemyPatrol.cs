using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float moveSpeed;
    public bool moveRight;
    private Vector3 scale;
    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    public bool hittingWall;

    public bool notAtEdge;
    public Transform edgeCheck;

    void Start()
    {
        scale = transform.localScale;
    }

    // Update is called once per frame
    private void Update()
    {
        notAtEdge = Physics.CheckSphere(edgeCheck.position, wallCheckRadius);

        hittingWall = Physics.CheckSphere(wallCheck.position, wallCheckRadius, whatIsWall);

        if (hittingWall || !notAtEdge)
        {
            moveRight = !moveRight;
        }

        if (moveRight)
        {
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
            GetComponent<Rigidbody>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody>().velocity.y);
        }

        else
        {
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);
            GetComponent<Rigidbody>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody>().velocity.y);
        }
    }
}
