using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;   
public class Timer : MonoBehaviour
{
    public TextMeshProUGUI text;
    float time = 0;

    // Update is called once per frame
    void Update()
    {
        text.text = time.ToString();

        time += Time.deltaTime;
    }
}
