using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
     Transform target;

    private void Awake() {
        
        target = GameObject.Find("Player").transform;
        transform.LookAt(target);
    }

    private void Update() {
    
        transform.forward = transform.forward*2;


 }
}
