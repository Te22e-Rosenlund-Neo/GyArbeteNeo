using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMen : MonoBehaviour
{
    
    public TextMeshProUGUI text;
    public void startgame(){
        // if(PlayerPrefs.GetInt("TimesPlayer") == 0){
            SceneManager.LoadScene(1);
        // }else{
        //     text.text = "You cant play more than once!";
        // }
    }
    public void stopgame(){
        Application.Quit();
    }    
}
