using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowDisapear : MonoBehaviour
{
    float timer = 0.8f;

    private void Update() {

        if(timer < 0){
            Destroy(gameObject);
        }

        timer -= Time.deltaTime;    
    }
}
