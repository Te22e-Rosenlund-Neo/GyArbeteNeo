using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanges : MonoBehaviour
{
    public GameObject Startup;
    public GameObject speechZone;
    Color color;
    
    void Start(){
        color = Startup.GetComponent<StartUpScript>().SetBackground;
    }

    public void SetSpeech(Sprite set){
        speechZone.GetComponent<SpriteRenderer>().sprite = set;
    } 

}
