using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public Transform Player;
    public GameObject Arrow;
    Quaternion FaceLeft = new(0,180,0,0);
    Quaternion FaceRight = new(0,0,0,0);

    public float turnspeed;

    private void LookAt(Transform Target)
    {

        float difference = Target.position.z - transform.position.z;

        if (difference < 0)
        {
            transform.rotation = Quaternion.Lerp(Quaternion.identity, FaceLeft, turnspeed);
        }
        else if (difference > 0)
        {
           transform.rotation = Quaternion.Lerp(Quaternion.identity, FaceRight, turnspeed);
        }

    }

    private void Shoot()
    {
        Instantiate(Arrow);
    }

    void Update()
    {

        LookAt(Player);

        if (Input.GetKeyDown(KeyCode.P))
        {
            Shoot();
        }

    }


}
