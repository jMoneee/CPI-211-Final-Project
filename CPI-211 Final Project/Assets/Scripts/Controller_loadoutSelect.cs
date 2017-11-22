using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller_loadoutSelect : MonoBehaviour
{
    //public int players;

    public Toggle p1Toggle, p2Toggle, p3Toggle, p4Toggle;
    public GameObject ButtonPanel;

    void Start()
    {
        
    }

    void Update()
    {
       
    }

    public void SwitchScenesWithButton(string nextScene)
    { SceneManager.LoadScene(nextScene); }



}
