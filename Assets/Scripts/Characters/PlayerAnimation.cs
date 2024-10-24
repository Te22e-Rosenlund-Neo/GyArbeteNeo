using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    // public Animator animator;

    private float Movement;
    private float height;
    private bool IsAttacking;
    [SerializeField] Transform player;
    RaycastHit hit;

    

    private void Update(){

        Physics.Raycast(player.position, Vector3.down, out hit, 20);

        height = Vector3.Distance(player.position, hit.point);



        // animator.SetFloat("Height", height);        
    }



}
