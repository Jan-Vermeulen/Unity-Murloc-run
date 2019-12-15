using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    CharacterController characterController;
    Animator animator;
    public int life = 3;
    public int score;
    public float speed;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private float currentSpeed;
    public float initialSpeed;
    public bool isSwiming = false;


    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        speed = initialSpeed;
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        currentSpeed = characterController.velocity.x;
        animator.SetFloat("Speed", currentSpeed);
        animator.SetBool("Swiming", isSwiming);
        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(speed, 0.0f, 0.0f);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                Jump();
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);       
    }


    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        hit.transform.SendMessage("OnTrigger", SendMessageOptions.DontRequireReceiver);
    }

    public void Jump()
    {
        if (!isSwiming)
        {
            moveDirection.y = jumpSpeed;
        }
    }

    public void Swim()
    {
        speed = 1.75f;
    }
}
