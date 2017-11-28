using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_playersMenu : MonoBehaviour
{
    static int playerCount;

    public void PlayerCountButtons(int num)
    {
        setPlayerCount(num);
        SceneManager.LoadScene("Loadout Menu");
    }

    public static int getPlayerCount() { return playerCount; }
    public static void setPlayerCount(int count) { playerCount = count; }

    public void SwitchSceneWithButton(string nextScene)
    { SceneManager.LoadScene(nextScene); }

}
