using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    public float speed = 8f;
    private bool isGrounded;
    public float gravity = -50f;
    public float jumpHeight = 3f;
 
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

 
    void Update()
    {
        isGrounded = controller.isGrounded;
        
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y; 
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }
        controller.Move(playerVelocity * Time.deltaTime);
        float x;
        float y;
        x =+ Vector3.Distance(playerVelocity, moveDirection);
        y =+ moveDirection.z;
        if (y > 0)
        {
          
           // AkSoundEngine.PostEvent("walkingStone", gameObject);
        }
        Debug.Log("Distance:" + Time.frameCount);
    }
    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
           
        }
    }



 



}
