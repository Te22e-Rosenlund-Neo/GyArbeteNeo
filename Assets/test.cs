using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{

    public Transform start;
    public Transform end;
    Vector3 Newpos;

    bool WasStart = true;

    float timer = 0;

    public void Update()
    {
            Debug.Log(timer);
            if(timer <= 0){

                if(WasStart == true){
                    Newpos = end.position;
                    WasStart = false;
                }else if(WasStart == false){
                    Newpos = start.position;
                    WasStart = true;
                }

                timer = 6f;
            }

            transform.position = Vector3.Lerp(transform.position, Newpos, Time.deltaTime);

            

        timer -= Time.deltaTime;
    }

    
}
