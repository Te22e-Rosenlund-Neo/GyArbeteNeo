using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public Transform player;
    public float speed;

    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player").transform;  
    }

    private void Update(){
    
    float move = Time.deltaTime * speed;

    if(Vector3.Distance(player.position, transform.position) < 10)

    transform.position = new Vector3(transform.position.x, transform.position.y, Vector3.MoveTowards(transform.position,player.position, move).z);
    
    }
}
