using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class StartUpScript : MonoBehaviour
{

    public Camera Camera1;    
    public GameObject DataSendObj;

    public GameObject SpeechZone;
    public Sprite SpeechRed;
    public Sprite SpeechBlue;
    public Sprite SpeechGreen;

    public Color SetBackground;
    public Material trees;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Color[] backgrounds = {Color.red, Color.green, Color.blue};

        SetBackground = backgrounds[UnityEngine.Random.Range(0, backgrounds.Length)];
        
        Camera1.backgroundColor = SetBackground;

        if(Convert.ToString(SetBackground) == "RGBA(0.000, 0.000, 1.000, 1.000)"){
            SetSpeech(SpeechBlue);
            DataSendObj.GetComponent<DataSender>().Color = "BLUE";
            trees.color = new Color(0.06285479f, 0.261895f, 0.7490197f, 1f);


        }else if(Convert.ToString(SetBackground) == "RGBA(1.000, 0.000, 0.000, 1.000)"){
            DataSendObj.GetComponent<DataSender>().Color = "RED";
            trees.color = new Color(0.4943395f, 0.113083f, 0.09980059f, 1f);
            
            SetSpeech(SpeechRed);
        }else{
            DataSendObj.GetComponent<DataSender>().Color = "GREEN";
            trees.color = new Color(0.1151559f, 0.4113207f, 0.07683153f, 1f);
            SetSpeech(SpeechGreen);
            
        }
    }

     public void SetSpeech(Sprite set){
        SpeechZone.GetComponent<SpriteRenderer>().sprite = set;
    } 
}



//blue: RGBA(0.000, 0.000, 1.000, 1.000)
//red:  RGBA(1.000, 0.000, 0.000, 1.000)
//green:    RGBA(0.000, 1.000, 0.000, 1.000)

