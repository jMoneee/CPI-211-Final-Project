using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{

    static int players;
    public Transform playerPrefab;

    // Use this for initialization
    void Start()
    {
        players = Controller_playersMenu.getPlayerCount();
        for (int i = 1; i <= players; i++)
        {
            float xpos = i * 10;
            Object instanceObj = Instantiate(playerPrefab, new Vector3(xpos, 0, 0), Quaternion.identity);
            instanceObj.name = "Player " + i;

        }
    }
}
