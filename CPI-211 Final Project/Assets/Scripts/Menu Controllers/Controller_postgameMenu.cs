using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_postgameMenu : MonoBehaviour
{
    public void SwitchScenesWithButton(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
        SoundManager.PlaySound("menu-forward");
    }
}
