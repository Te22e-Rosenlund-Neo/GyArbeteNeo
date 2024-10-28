using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
     public Transform target;

    private void Start() {
        target = GameObject.Find("Player").transform;

        transform.LookAt(target);
       
    }

    private void Update() {
    
        // transform.position = Vector3.MoveTowards(transform.position, target.position, float.MaxValue);

 }
}
