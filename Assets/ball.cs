using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ball : MonoBehaviour
{
    public List<Button> buttons;
    public TextMeshProUGUI test;
    void Awake()
    {
        foreach (var button in buttons){
            button.gameObject.SetActive(false);
            test.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
     private void OnTriggerEnter(Collider other)
    {
        other.transform.GetComponent<jumptest>().enabled = false;
        foreach (var button in buttons){
            button.gameObject.SetActive(true);
            test.gameObject.SetActive(true);
        }
    }
}
