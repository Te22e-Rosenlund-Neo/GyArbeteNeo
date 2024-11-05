using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public Transform Player;
    public GameObject Arrow;
    private void Shoot()
    {
        Instantiate(Arrow);
    }

    void Update()
    {

       

        if (Input.GetKeyDown(KeyCode.P))
        {
            Shoot();
        }

    }


}
