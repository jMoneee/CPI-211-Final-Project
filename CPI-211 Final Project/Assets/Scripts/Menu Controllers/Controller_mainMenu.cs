﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_mainMenu : MonoBehaviour
{

    public void SwitchSceneWithButton(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
        SoundManager.PlaySound("menu-forward");
    }

    public void QuitGameBtn() { Application.Quit(); }
}
