using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner_Col : MonoBehaviour {

    static int players;
    public Transform playerPrefab;
    private Vector3 spawnLocation;

    // Use this for initialization
    void Start()
    {
        players = Controller_playersMenu.getPlayerCount();
        for (int i = 1; i <= players; i++)
        {
            switch (i)
            {
                case 1:
                    spawnLocation = new Vector3(354, 5, 285);
                    break;

                case 2:
                    spawnLocation = new Vector3(-353, 5, -261);
                    break;

                case 3:
                    spawnLocation = new Vector3(-353, 5, 285);
                    break;

                case 4:
                    spawnLocation = new Vector3(354, 5, -261);
                    break;
            }

            Object instanceObj = Instantiate(playerPrefab, spawnLocation, Quaternion.identity);
            instanceObj.name = "Player " + i;
        }
    }
}
