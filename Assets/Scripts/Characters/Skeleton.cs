using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
        public Transform Player;
        public GameObject Arrow;

        
    private void LookAt(Transform Target){

        float difference = Target.position.z - transform.position.z;

       if(difference < 0){
        transform.rotation = new Quaternion(0,180,0,0);
       }
       else if(difference > 0){
        transform.rotation = new Quaternion(0,0,0,0);
       }
    }

    private void Shoot(){
        Instantiate(Arrow);
    }   

    void Update(){

        LookAt(Player);

        if(Input.GetKeyDown(KeyCode.P)){
            Shoot();
        }

    }





}
