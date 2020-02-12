using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 positionDirection;
    public float speed = 10f;
    public float gravity = 3f;
    public float jumpForce = 30f;
    public int jumpCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }
        positionDirection.x = Input.GetAxis("Horizontal")*speed;

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            positionDirection.y = jumpForce;
            jumpCount++;
        }
        positionDirection.y -= gravity;
        controller.Move(motion: positionDirection * Time.deltaTime);
    }
}
