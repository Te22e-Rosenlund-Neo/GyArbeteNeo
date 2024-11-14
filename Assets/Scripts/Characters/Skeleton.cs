using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    // FOR ANIMATION

    public Animator skelly;
    public Animator bow;
    

    // REST
    public Transform Player;
    public GameObject ArrowAnimation;
    public Transform ArrowSpawnLocation;

    private IEnumerator Shoot(){

        skelly.SetBool("Shoot", true);
        bow.SetBool("Shoot", true);
        Instantiate(ArrowAnimation, ArrowSpawnLocation);
        yield return new WaitForSeconds(0.1f);
        
        skelly.SetBool("Shoot", false);
        bow.SetBool("Shoot", false);

    }

    void Update()
    {

       

        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(Shoot());
        }

    }


}
