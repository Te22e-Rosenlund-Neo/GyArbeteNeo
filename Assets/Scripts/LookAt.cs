using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Quaternion FaceLeft = new(0,180,0,0);
    [SerializeField] Quaternion Faceright = new(0,0,0,0);
    public Transform target;
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
           transform.rotation = Quaternion.Lerp(Quaternion.identity, Faceright, turnspeed);
        }

    }

    private void Update(){
          LookTowards(target);  
    }
}
