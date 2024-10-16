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
    [SerializeField] private int jumpCount = 0;
    [SerializeField] string GroundTag;
    public float gravity;

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
        rb.AddForce(0, -gravity, 0);
        rb.velocity = new Vector3(0, 0, MoveDirection.x*MoveSpeed); 

        if(jumpCount > 0){
        rb.AddForce(new Vector3(0,MoveDirection.y * JumpForce,0));
        }
    }


    private void OnTriggerEnter(Collider other) {
    if(other.tag == GroundTag){
        if(jumpCount == 0){
            jumpCount += 1;
        }
    }
    }
    private void OnTriggerExit(Collider other) {
       if(other.tag == GroundTag){
        jumpCount = 0;
    } 
    }
}

