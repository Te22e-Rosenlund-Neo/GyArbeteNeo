using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowDisapear : MonoBehaviour
{
    float timer = 0.8f;
    public GameObject Arrow;
    
    
    private void Update() {

        if(timer < 0){
            Instantiate(Arrow, transform.position, Quaternion.identity);
            // Destroy(gameObject);
            timer += 100000009000;
        }

        timer -= Time.deltaTime;    
    }
}
