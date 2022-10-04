using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public InputAction playerControls;

    public float speed = 12f;
    public float sprintSpeed = 1f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundLayerMask;

    public AudioSource footstepsSound;
    public AudioSource sprintSound;
    public AudioSource jumpSound;

    Vector3 velocity;
    bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayerMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * x + transform.forward * z);

        // This will prevent move speed increasing when moving player character diagonally
        move = Vector3.ClampMagnitude(move, speed);

        controller.Move(move * speed * Time.deltaTime);


        // If player isGrounded and is using directional keys, then foostepsSound is playing
        if (isGrounded && Input.GetKey("w") || isGrounded && Input.GetKey("a") || isGrounded && Input.GetKey("s") || isGrounded && Input.GetKey("d"))
        {
            // If player sprints with L.Shift, then sprintSound is enabled and movement speed is increased
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false;
                sprintSound.enabled = true;
                controller.Move(move * (speed + sprintSpeed )* Time.deltaTime);




            }
            else
            {
                footstepsSound.enabled = true;
                sprintSound.enabled = false;

            }
        }
        else
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }

        
   
        if (Input.GetButtonDown("Jump") && isGrounded)
        {   
            // Jumpsound is played
            jumpSound.Play();
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
    //Movement script for JumpPad and sorts. Case is "tag" 
    private void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        switch(hit.gameObject.tag)
        {
            case "JumpPad":
                jumpHeight = 20f;
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                //Debug.Log("BOUNCE!");
                jumpHeight = 3f;
                break;
            case "Ground":
                jumpHeight = 3f;
                break;
        }
    }

    //Stops footstepsSound when player is colliding with ladders
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ladder")
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }
        
    }
}
