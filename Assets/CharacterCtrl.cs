using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCtrl : MonoBehaviour
{
  CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private float currspeed;
    private Animator AnimController;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        AnimController = GetComponent<Animator>();
    }

    void Update()
    { 
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 inputDir = input.normalized;

        if(inputDir != Vector2.zero)
        {
            AnimController.SetBool("walk", true);
        }
        else
        {
            AnimController.SetBool("walk", false);
        }

        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= speed;
 
        moveDirection.y -= gravity * Time.deltaTime;

       
        characterController.Move(moveDirection * Time.deltaTime);
        
    }
}
