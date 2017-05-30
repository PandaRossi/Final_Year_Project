
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 moveVector;

    public float speed = 7.0f;
    private float verticalVelocity = 0.0f;
    public float gravity = 12.0f;
    public float jumpForce = 10.0f;

    public bool canJump;
    public bool temp;

    

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
        temp = false;       

    }

    // Update is called once per frame
    void Update()
    {

        if (controller.isGrounded)                                               //Checking to see if the player is on the ground
        {
            
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetButtonDown("Jump") || temp)
            {
                verticalVelocity = jumpForce;
                temp = false;   
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;                       //If the player is not on the ground, gravity will push them back down
        }

        

        moveVector = new Vector3(0, verticalVelocity, 0);


        //z forward and backward
        moveVector.z = speed;                                                   //The character is moving along the z-axis at a constant value

        controller.Move(moveVector * Time.deltaTime);                           //Updating the movements of the player each frame
    }

    public void Jump()
    {
        temp = true;
    }

    public void Reset()
    {
        temp = false;
    }
}
