using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public Transform player;
    public float speed;
    public float PushForce;
    public float UpForce;
    Vector3 PushDirection;
    Vector3 Push;
    bool StartPush = false;
    float timerforpush;
    Rigidbody PRb;

    public int hp = 3;

    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player").transform;  
        transform.position = new Vector3(4.319687f, transform.position.y, transform.position.z);
    }

    private void Update(){
    
    float move = Time.deltaTime * speed;

    if(Vector3.Distance(player.position, transform.position) < 6)

    transform.position = new Vector3(transform.position.x, transform.position.y, Vector3.MoveTowards(transform.position,player.position, move).z);
    
    if(hp <= 0){
        Destroy(gameObject);
    }

    }

        private void OnCollisionEnter(Collision other) {
            if(other.transform == player){

                PRb = other.gameObject.GetComponent<Rigidbody>();

                other.transform.GetComponent<jumptest>().disabledMove = 0;

                PushDirection = (other.transform.position - transform.position).normalized;

                Push = new Vector3(PushDirection.x, UpForce, PushDirection.z) * PushForce;

                StartPush = true;
                timerforpush = 0.2f;


            }
        }
        private void OnCollisionExit(Collision other) {
            if(other.transform == player){
                other.transform.GetComponent<jumptest>().disabledMove = 1;
                other.transform.GetComponent<jumptest>().HP -= 1;
            }
        }
        private void FixedUpdate() {
            if(StartPush == true && timerforpush > 0){
                PRb.AddForce(Push, ForceMode.Impulse);

            

            }

            if(timerforpush > 0){
                timerforpush -= Time.deltaTime;
            }
        }


}
