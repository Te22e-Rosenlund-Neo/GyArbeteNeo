using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal.VR;
using UnityEngine;

public class Actions : MonoBehaviour
{
    [SerializeField] GameObject Sword;
    public float AttackSpeed;
    float timer;
    private void Update(){


        if(timer > AttackSpeed && Input.GetKeyDown(KeyCode.Mouse0)){

            Instantiate(Sword);
            timer = 0;   
        }
    timer += Time.deltaTime;
    }




    

}
