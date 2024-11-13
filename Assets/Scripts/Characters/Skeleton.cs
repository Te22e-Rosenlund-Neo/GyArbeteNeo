using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    // FOR ANIMATION

    public Animator skelly;
    public Animator bow;
    public Animator arrow;

    // REST
    public Transform Player;
    public GameObject Arrow;
    private IEnumerator Shoot(){
        skelly.SetBool("Shoot", true);
        bow.SetBool("Shoot", true);
        arrow.SetBool("Shoot", true);
        yield return new WaitForSeconds(0.8f);
        
        Instantiate(Arrow);
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
