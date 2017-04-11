<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 moveVector;

    private float speed = 7.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;
    private float jumpForce = 10.0f;

    public bool canJump;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
      

    }

    // Update is called once per frame
    void Update()
    {

        if (controller.isGrounded)                                               //Checking to see if the player is on the ground
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetButtonDown("Jump"))
            {
                verticalVelocity = jumpForce;                                   //If the player hits the spacebar, the character will jump
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


}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 moveVector;

    private float speed = 7.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;
    private float jumpForce = 10.0f;

    public bool canJump;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
      

    }

    // Update is called once per frame
    void Update()
    {

        if (controller.isGrounded)                                               //Checking to see if the player is on the ground
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetButtonDown("Jump"))
            {
                verticalVelocity = jumpForce;                                   //If the player hits the spacebar, the character will jump
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


}
>>>>>>> master
