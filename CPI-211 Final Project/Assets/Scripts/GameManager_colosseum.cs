using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_colosseum : MonoBehaviour
{
    private static int currentPlayers;
    public GameObject[] startingListOfPlayers;
    public static int[] playerScoreList;
    public GameObject[] listOfPlayers;

    // Update is called once per frame
    void Update()
    {
        if (startingListOfPlayers.Length == 0)
        {
            startingListOfPlayers = GameObject.FindGameObjectsWithTag("Player");
            currentPlayers = startingListOfPlayers.Length;
            playerScoreList = new int[startingListOfPlayers.Length];
        }
        listOfPlayers = GameObject.FindGameObjectsWithTag("Player");
        currentPlayers = listOfPlayers.Length;

        if (currentPlayers == 1)
        {
            SetPlayerList();
            SceneManager.LoadScene("End Screen");
        }
    }

    void SetPlayerList()
    {
        for (int i = 0; i < Controller_playersMenu.getPlayerCount(); i++)
        { playerScoreList[i] = startingListOfPlayers[i].GetComponent<Player_Controller>().getPlacement(); }
    }

    public static int getCurrentPlayers() { return currentPlayers; }
    public static void setCurrentPlayers(int players) { currentPlayers = players; }
    public static int[] getPlayerScoreList() { return playerScoreList; }

}
