using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_stageMenu : MonoBehaviour
{
    public void ProgressWithButton(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
        SoundManager.PlaySound("menu-forward");
    }

    public void DigressWithButton()
    {
        SceneManager.LoadScene("PlayerSelect Menu");
        SoundManager.PlaySound("menu-back");
    }
}
