using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSelector : MonoBehaviour
{
    static int players;
    public GameObject[] cameraList;
    public GameObject parent;
    // Use this for initialization
    void Start()
    {
        parent = this.transform.parent.parent.parent.gameObject;
        players = Controller_playersMenu.getPlayerCount();
        if (parent.name == "Player 1")
        {
            if (players == 2)
            {
                cameraList[0].SetActive(true);
                parent.GetComponent<Player_Controller>().getDeathCam(0);
            }
            else if (players > 2)
            {
                cameraList[1].SetActive(true);
                parent.GetComponent<Player_Controller>().getDeathCam(1);
            }
        }

        else if (parent.name == "Player 2")
        {
            if (players == 2)
            {
                cameraList[2].SetActive(true);
                parent.GetComponent<Player_Controller>().getDeathCam(2);
            }
            else if (players > 2)
            {
                cameraList[3].SetActive(true);
                parent.GetComponent<Player_Controller>().getDeathCam(3);
            }
        }

        else if (parent.name == "Player 3")
        {
            cameraList[4].SetActive(true);
            parent.GetComponent<Player_Controller>().getDeathCam(4);
        }
        else if (parent.name == "Player 4")
        {
            cameraList[5].SetActive(true);
            parent.GetComponent<Player_Controller>().getDeathCam(5);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
