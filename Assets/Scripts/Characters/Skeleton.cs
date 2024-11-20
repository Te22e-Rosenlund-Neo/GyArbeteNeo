using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
public class Skeleton : MonoBehaviour
{
    // FOR ANIMATION

    public Animator skelly;
    public Animator bow;
    

    // REST
    public Transform Player;
    public GameObject ArrowAnimation;
    public Transform ArrowSpawnLocation;
    public Transform target;
    public TextMeshPro text;
    float timebetweenshots = 1f;

    public int hp = 2;

    private IEnumerator Shoot(){

        skelly.SetBool("Shoot", true);
        bow.SetBool("Shoot", true);
        var e = Instantiate(ArrowAnimation, ArrowSpawnLocation.position, Quaternion.identity);
        e.transform.LookAt(transform.forward*10);
        e.transform.rotation = transform.rotation;
        e.GetComponent<arrowDisapear>().SetString(ArrowSpawnLocation);
        e.GetComponent<arrowDisapear>().SetTarget(target);
        // e.transform.position = ArrowSpawnLocation.localPosition;
        yield return new WaitForSeconds(0.1f);
        
        skelly.SetBool("Shoot", false);
        bow.SetBool("Shoot", false);

    }

    void Update()
    {
        if(Vector3.Distance(Player.position, transform.position) < 10 && timebetweenshots <= 0){
            StartCoroutine(Shoot());
            timebetweenshots = 2f;
        }

        text.text = hp.ToString();

       
        if(hp <= 0){
            Destroy(gameObject);
        }



        // if (Input.GetKeyDown(KeyCode.P))
        // {
        //     StartCoroutine(Shoot());
        //     // GameObject e = Instantiate(ArrowAnimation, ArrowSpawnLocation.position, Quaternion.identity);
        // }
        timebetweenshots -= Time.deltaTime;
    }
    // private void OnDrawGizmos() {
    //     Gizmos.color = Color.green;
    //     Gizmos.DrawSphere(ArrowSpawnLocation.position, 0.1f);
    // }
    
}
