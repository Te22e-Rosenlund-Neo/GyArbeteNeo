using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NpcTe : MonoBehaviour
{
    public TextMeshPro textbox;
    string text1 = "OMG thank you for \n coming so quickly!";
    string text2 = "The evils have taken \n control of the castle";
    string text3 = "Please save us!";
    bool doonce = true;
     IEnumerator textchanger(){
        textbox.text = text1;
        yield return new WaitForSeconds(4);
        textbox.text = text2;   
        yield return new WaitForSeconds(4);
        textbox.text = text3;

    }
    void Update(){
        if(doonce == true){
        StartCoroutine(textchanger());
        doonce = false;
        }
    }
    }

   

