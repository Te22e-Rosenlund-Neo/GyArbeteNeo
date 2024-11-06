using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public Transform player;
    public float speed;
    public float PushForce;
    public float UpForce;

    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player").transform;  
        transform.position = new Vector3(4.319687f, transform.position.y, transform.position.z);
    }

    private void Update(){
    
    float move = Time.deltaTime * speed;

    if(Vector3.Distance(player.position, transform.position) < 10)

    transform.position = new Vector3(transform.position.x, transform.position.y, Vector3.MoveTowards(transform.position,player.position, move).z);
    
    }

        private void OnCollisionEnter(Collision other) {
            if(other.transform == player){

                Rigidbody PRb = other.gameObject.GetComponent<Rigidbody>();

                Vector3 PushDirection = (other.transform.position - transform.position).normalized;

                Vector3 Push = new Vector3(PushDirection.x, UpForce, PushDirection.z) * PushForce;

                PRb.AddForce(Push, ForceMode.Impulse);



            }
        }


}
