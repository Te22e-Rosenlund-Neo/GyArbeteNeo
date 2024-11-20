using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordSwing : MonoBehaviour
{
    private float AliveTime = 1;
    private Transform player;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        transform.position = player.position + new Vector3(0,1,0) + player.forward;
        StartCoroutine(SwordSwing());
    }


    IEnumerator SwordSwing(){
    
    
    yield return new WaitForSeconds(AliveTime);
    Destroy(gameObject);

    }

     private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Slime")){
            other.transform.GetComponent<Slime>().hp -= 1;
        }
        if(other.CompareTag("Skelly")){
            other.transform.GetComponent<Skeleton>().hp -= 1;
        }
    }
}
