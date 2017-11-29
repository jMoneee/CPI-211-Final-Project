using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller_optionsMenu : MonoBehaviour
{
    public Slider[] volumeSliders;

    void Start()
    {

    }

    public void ReturnToMainMenuBtn(string nextScene)
    { SceneManager.LoadScene(nextScene); }

    public void SetMasterVolume(int value)
    {
        
    }

    public void SetMusicVolume(int value)
    {

    }

    public void SetSFXVolume(int value)
    {

    }
}
