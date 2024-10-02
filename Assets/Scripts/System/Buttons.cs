using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadSceneAsync(2);
    }
    public void Information(){
        SceneManager.LoadSceneAsync(1);
    }
    public void Menu(){
         SceneManager.LoadSceneAsync(0);
    }
    public void quit(){
        Application.Quit();
    }
    public void ResultScreen(){
         SceneManager.LoadSceneAsync(3);
    }
}
