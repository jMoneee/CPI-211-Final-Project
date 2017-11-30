using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeaderboardController : MonoBehaviour {

    public Text first;
    public Text second;
    public Text third;
    public Text fourth;
    public int[] playerList;

    // Use this for initialization


    void Start()
    {
        playerList = GameManager_colosseum.getPlayerScoreList();
        BuildLeaderboard();
    }

    void BuildLeaderboard()
    {
        for (int i = 0; i < Controller_playersMenu.getPlayerCount(); i++)
        {
            if (playerList[i] == 0)
            { first.text = "1st Place: Player " + (i+1); }

            if (playerList[i] == 2)
            { second.text = "2nd Place: Player " + (i+1); }

            if (playerList[i] == 3)
            { third.text = "3rd Pl=ace: Player " + (i+1); }

            if (playerList[i] == 4)
            { fourth.text = "4th Place: Player " + (i+1); }
        }

        if (Controller_playersMenu.getPlayerCount() < 3) { third.gameObject.SetActive(false); }
        if (Controller_playersMenu.getPlayerCount() < 4) { fourth.gameObject.SetActive(false); }
    }
}
