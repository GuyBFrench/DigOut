using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovmentBehavior : MonoBehaviour
{
    public InputMaster controls;

    private void Awake()
    {
        controls = new InputMaster();
        controls.Player.Shoot.performed += _ => Shoot();
        controls.Player.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }

    void Move(Vector2 direction)
    {
        Debug.Log("Move " + direction);
    }
    
    void Shoot()
    {
        Debug.Log("Shot");
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
