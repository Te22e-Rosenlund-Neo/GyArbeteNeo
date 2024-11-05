using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScaler : MonoBehaviour
{
    
    static float GlobalGravity = -9.81f;

    public List<Rigidbody> Bodies;
     

    public float DefaultGravityScale;
    


    // Update is called once per frame
    private void OnEnable() {
        


    }
    void Update()
    {

        Bodies = new List<Rigidbody>(FindObjectsByType<Rigidbody>(FindObjectsSortMode.None));

        Vector3 gravity = GlobalGravity * DefaultGravityScale * Vector3.up;

        foreach(Rigidbody body in Bodies){
            body.AddForce(gravity, ForceMode.Acceleration);
        }



        
        

    }
}
