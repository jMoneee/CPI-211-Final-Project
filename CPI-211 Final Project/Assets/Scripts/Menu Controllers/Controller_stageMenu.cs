using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_stageMenu : MonoBehaviour
{
    public void SwitchScenesWithButton(string nextScene)
    { SceneManager.LoadScene(nextScene); }
}
