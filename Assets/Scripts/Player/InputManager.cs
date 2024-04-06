using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput PlayerInput;
    private PlayerInput.OnFootActions OnFoot;
    private PlayerLook Look;

    private PlayerMotor Motor;

    // Start is called before the first frame update
    void Awake()
    {
        PlayerInput = new PlayerInput();
        OnFoot = PlayerInput.OnFoot;
        Motor = GetComponent<PlayerMotor>();
        Look = GetComponent<PlayerLook>();
        OnFoot.Jump.performed += ctx => Motor.Jump();
   
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Motor.ProcessMove(OnFoot.Movement.ReadValue<Vector2>());
        

    }
    private void LateUpdate ()
    {
        Look.ProcessLook(OnFoot.Look.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
        OnFoot.Enable();
    }

    private void OnDisable()
    {
        OnFoot.Disable();
    }
}
