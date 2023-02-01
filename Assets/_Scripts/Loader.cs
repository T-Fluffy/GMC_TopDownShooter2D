using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loader : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject InfoPanel;
    public void loadLvl(string name){
        SceneManager.LoadScene(name);
    }
    public void Exit(){
        Application.Quit();
    }
    public void LoadInfo(){
        InfoPanel.SetActive(true);
        MenuPanel.SetActive(false);
    }
    public void LoadMenu(){
        MenuPanel.SetActive(true);
        InfoPanel.SetActive(false);
    }
}
