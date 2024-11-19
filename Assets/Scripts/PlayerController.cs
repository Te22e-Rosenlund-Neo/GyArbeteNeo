using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class jumptest : MonoBehaviour
{
    public float JumpForce;
    public float GroundDistance = 0.5f;

    public Transform RayCastPoint;

    public int HP = 3;

    public float MoveSpeed;
    public int disabledMove = 1;
// 1 = able to move, 0 = unable to move

    public Rigidbody rb;
    bool IsGrounded(){
        // return Physics.Raycast(transform.position, Vector3.down, GroundDistance);
        return Physics.Raycast(new Ray(transform.position + new Vector3(0,1,0), Vector3.down), GroundDistance);
    }
    private void Start(){
        
    }

    private void Update() {

        Debug.DrawRay(transform.position+ new Vector3(0,1,0), Vector3.down, Color.red);
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded() == true){
            rb.velocity = new Vector3(rb.velocity.x,1,rb.velocity.z) * JumpForce;
        }

        float MoveDirection = Input.GetAxisRaw("Horizontal");


        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, MoveDirection*MoveSpeed*disabledMove);

    }
    
}
