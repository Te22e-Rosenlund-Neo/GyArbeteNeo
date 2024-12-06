using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {
        other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 40, other.transform.position.z);    
   }
}
