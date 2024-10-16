using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumptest : MonoBehaviour
{
     public float JumpForce;
     public float GroundDistance = 0.5f;

     public Rigidbody rb;

     bool IsGrounded(){
        return Physics.Raycast(transform.position, Vector3.down, GroundDistance);
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded() == true){
            rb.velocity = new Vector3(0,1,0) * JumpForce;
        }

    }
}
