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
    void Awake()
    {
        Color[] backgrounds = {Color.red, Color.green, Color.blue};

        Color SetBackground = backgrounds[UnityEngine.Random.Range(0, backgrounds.Length)];
        
        Camera1.backgroundColor = SetBackground;

        if(Convert.ToString(SetBackground) == "RGBA(0.000, 0.000, 1.000, 1.000)"){

            DataSendObj.GetComponent<DataSender>().Color = "BLUE";

        }else if(Convert.ToString(SetBackground) == "RGBA(1.000, 0.000, 0.000, 1.000)"){
            DataSendObj.GetComponent<DataSender>().Color = "RED";
        }else{
            DataSendObj.GetComponent<DataSender>().Color = "GREEN";
        }
    }
}



//blue: RGBA(0.000, 0.000, 1.000, 1.000)
//red:  RGBA(1.000, 0.000, 0.000, 1.000)
//green:    RGBA(0.000, 1.000, 0.000, 1.000)

