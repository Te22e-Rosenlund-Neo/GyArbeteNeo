using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLocker : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if(PlayerPrefs.GetInt("TimesPlayer", 0) > 0){

            //You are no longer allowed to play, thank you for the help!

        }
    }
}
