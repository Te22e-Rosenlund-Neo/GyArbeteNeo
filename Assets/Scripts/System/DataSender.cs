using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.PlayerLoop;



public class DataSender : MonoBehaviour
{
    public string Color;
    public string HTT;
    
    private string FormUrl = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSdThm9CLWU5He9L-JWUU1weJpFZHVE-b4y8lFheFAFQSsZ7Jg/formResponse";


    public void SendDataValues(){

        StartCoroutine(Post(Color, HTT));
            }


    private IEnumerator Post(string data1, string data2){

        WWWForm form = new WWWForm();
        form.AddField("entry.1978531111", data1);
        form.AddField("entry.300462831", data2);

        using(UnityWebRequest www= UnityWebRequest.Post(FormUrl, form)){
            
            yield return www.SendWebRequest();

            if(www.result == UnityWebRequest.Result.Success){
                Debug.Log("Data sent successfully");
                PlayerPrefs.SetInt("TimesPlayer", 1);
            }else{
                Debug.LogError("An error occurred:" + www.error);
            }
        }
    }

    public void SetHTT(string value){

        HTT = value;
        SendDataValues();
    }






}
