﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner_Fig8 : MonoBehaviour
{ 
    static int players;
    public Transform playerPrefab;
    private Vector3 spawnLocation;
    public GameObject deathCams;

    // Use this for initialization
    void Start()
    {
        players = Controller_playersMenu.getPlayerCount();
        for (int i = 1; i <= players; i++)
        {
            switch (i)
            {
                case 1:
                    spawnLocation = new Vector3(301, 42, 372);
                    break;

                case 2:
                    spawnLocation = new Vector3(-248, 42, -354);
                    break;

                case 3:
                    spawnLocation = new Vector3(-248, 42, 372);
                    break;

                case 4:
                    spawnLocation = new Vector3(301, 42, -354);
                    break;
            }
            Object instanceObj = Instantiate(playerPrefab, spawnLocation, Quaternion.identity);
            instanceObj.name = "Player " + i;

            if (players == 3) { deathCams.transform.GetChild(5).gameObject.SetActive(true); }
        }
    }
}
