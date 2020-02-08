using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 positionDirection;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal")*speed;

        if (Input.GetButtonDown("Jump"))
        {
            positionDirection.y = jumpForce;
        }
        positionDirection.y -= gravity;
        controller.Move(motion: positionDirection * Time.deltaTime);
    }
}
