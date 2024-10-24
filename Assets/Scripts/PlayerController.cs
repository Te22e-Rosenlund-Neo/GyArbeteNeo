using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumptest : MonoBehaviour
{
    public float JumpForce;
    public float GroundDistance = 0.5f;

    public float MoveSpeed;
    float MoveDirection;

    public Rigidbody rb;
    RaycastHit hit;

    bool IsGrounded(){
        return Physics.Raycast(transform.position, Vector3.down, GroundDistance);
    }
    private void Start(){
        
    }

    private void Update() {

        
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded() == true){
            rb.velocity = new Vector3(rb.velocity.x,1,rb.velocity.z) * JumpForce;
        }

        float MoveDirection = Input.GetAxisRaw("Horizontal");


        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, MoveDirection*MoveSpeed);

    }
}
