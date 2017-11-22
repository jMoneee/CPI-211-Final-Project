using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_playersMenu : MonoBehaviour
{
    public void SwitchScenesWithButton(string nextScene)
    { SceneManager.LoadScene(nextScene); }

}
