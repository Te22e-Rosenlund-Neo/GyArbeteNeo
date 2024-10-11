using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public InputAction Controlls;
    public Vector3 MoveDirection;
    [SerializeField] private float MoveSpeed = 5;
    [SerializeField] private float JumpForce = 10;
    private int jumpCount = 1;

    private void OnEnable() {
        Controlls.Enable();    
    }
    private void OnDisable() {
        Controlls.Disable();
    }

    private void Update() {
        MoveDirection = Controlls.ReadValue<Vector3>();
    }
    private void FixedUpdate() {
        rb.AddForce(0, -200, 0);
        rb.velocity = new Vector3(0, 0, MoveDirection.x*MoveSpeed); 

        if(jumpCount > 0){
        rb.AddForce(new Vector3(0,MoveDirection.y * JumpForce,0), ForceMode.Impulse);
        jumpCount-=1;
        }
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(jumpCount == 0){
            jumpCount += 1;
        }
    }

}
