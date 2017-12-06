using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSelector : MonoBehaviour
{
    static int players;
    public GameObject[] cameraList;
    // Use this for initialization
    void Start()
    {
        players = Controller_playersMenu.getPlayerCount();
        if (this.transform.parent.parent.parent.name == "Player 1")
        {
            if (players == 2)
                cameraList[0].SetActive(true);
            else if (players > 2)
                cameraList[1].SetActive(true);
        }

        else if (this.transform.parent.parent.parent.name == "Player 2")
        {
            if (players == 2)
                cameraList[2].SetActive(true);
            else if (players > 2)
                cameraList[3].SetActive(true);
        }

        else if (this.transform.parent.parent.parent.name == "Player 3")
            cameraList[4].SetActive(true);
        else if (this.transform.parent.parent.parent.name == "Player 4")
            cameraList[5].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
