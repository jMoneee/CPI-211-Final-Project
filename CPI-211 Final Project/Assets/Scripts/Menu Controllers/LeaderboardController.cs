using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardController : MonoBehaviour {

    public Text first;
    public Text second;
    public Text third;
    public Text fourth;
    public GameObject temp;

    // Use this for initialization
    void Start ()
    {
        //for (int i = 0; i < Controller_playersMenu.getPlayerCount(); i++)
        //{
        //    temp = GameManager_colosseum.getPlayerFromList(i);
        //    if (temp.getPlacement() == 0)
        //    { first.text.Equals("1st Place: Player " + i); }

        //    if (temp.getPlacement() == 2)
        //    { second.text.Equals("2nd Place: Player " + i); }

        //    if (temp.getPlacement() == 3)
        //    { third.text.Equals("3rd Place: Player " + i); }

        //    if (temp.getPlacement() == 4)
        //    { fourth.text.Equals("4th Place: Player " + i); }
        //}

		if (Controller_playersMenu.getPlayerCount() > 3) { third.gameObject.SetActive(false); }
        if (Controller_playersMenu.getPlayerCount() > 4) { fourth.gameObject.SetActive(false); }


	}

}
