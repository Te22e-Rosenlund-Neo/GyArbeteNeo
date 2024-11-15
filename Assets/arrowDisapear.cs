using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class arrowDisapear : MonoBehaviour
{
    float timer = 0.6f;
    Transform position;
    public string playertag;
    [SerializeField] float speed;
    public Transform target;


    private void Update()
    {

        if (timer > 0)
        {
            if(position != null){
            FollowString();
            }
        }else if(timer < 0){
            Debug.Log(new Vector3(transform.position.x, transform.position.y, transform.forward.z*100));
            transform.position = Vector3.MoveTowards(transform.position,target.position, speed*Time.deltaTime);
            if(transform.position == target.position){
                Destroy(gameObject);
            }
        }

        timer -= Time.deltaTime;
    }

    void FollowString()
    {

        transform.position = position.position;

    }

    public void SetString(Transform str)
    {
        position = str;
    }
    public void SetTarget(Transform targ){

        target = targ;
    }



    private void OnTriggerEnter(Collider other) {
        if(other.transform.tag == playertag){
            other.gameObject.GetComponent<jumptest>().HP -= 1;
        }
    }



}
