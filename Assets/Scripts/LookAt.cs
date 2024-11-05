using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{

    public Transform target;
    Quaternion FaceLeft = new(0,180,0,0);
    Quaternion FaceRight = new(0,0,0,0);
    float turnspeed = 0.1f;

    private void LookTowards(Transform Target)
    {

        float difference = Target.position.z - transform.position.z;

        if (difference < 0)
        {
            transform.rotation = Quaternion.Lerp(Quaternion.identity, FaceLeft, turnspeed);
        }
        else if (difference > 0)
        {
           transform.rotation = Quaternion.Lerp(Quaternion.identity, FaceRight, turnspeed);
        }

    }

    private void Update(){
          LookTowards(target);  
    }
}
