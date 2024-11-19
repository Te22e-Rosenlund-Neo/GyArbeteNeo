using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private Vector3 Ytop;
    private Vector3 Ybottom;


    void Start(){
        Ytop = transform.position;
        Ybottom = new Vector3(transform.position.x, transform.position.y -20, transform.position.z);
    }
    void Update(){

        if(transform.position == Ytop){
            Debug.Log(Ybottom);
             transform.position = Ybottom;
        }
        if(transform.position == Ybottom){
            Debug.Log(Ytop);
            transform.position = Vector3.Lerp(transform.position, Ytop, 1);
        }
    }
}
