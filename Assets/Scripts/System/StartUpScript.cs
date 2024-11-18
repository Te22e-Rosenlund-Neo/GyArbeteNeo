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
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Color[] backgrounds = {Color.red, Color.green, Color.blue};

        SetBackground = backgrounds[UnityEngine.Random.Range(0, backgrounds.Length)];
        
        Camera1.backgroundColor = SetBackground;

        if(Convert.ToString(SetBackground) == "RGBA(0.000, 0.000, 1.000, 1.000)"){
            SetSpeech(SpeechBlue);
            DataSendObj.GetComponent<DataSender>().Color = "BLUE";
            

        }else if(Convert.ToString(SetBackground) == "RGBA(1.000, 0.000, 0.000, 1.000)"){
            DataSendObj.GetComponent<DataSender>().Color = "RED";
            SetSpeech(SpeechRed);
        }else{
            DataSendObj.GetComponent<DataSender>().Color = "GREEN";
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

