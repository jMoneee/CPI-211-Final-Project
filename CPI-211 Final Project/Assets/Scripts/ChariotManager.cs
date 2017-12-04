using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChariotManager : MonoBehaviour {

    public Transform theChariot;
    public int selectedChariot;
    public float chariotDefense;
    public int hitboxSize;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        getChariot();

        theChariot = this.transform.GetChild(selectedChariot);
        theChariot.gameObject.SetActive(true);

        computeChariotDefense();

        player.GetComponent<Player_Controller>().setChariotStats(chariotDefense, hitboxSize);
    }

    void getChariot()
    {
        if (Player_Controller.getPlayerNumber() == 1)
        {
            if (Controller_playersMenu.getPlayerCount() == 2) { selectedChariot = LoadoutManager1.getChariot(1); }
            else if (Controller_playersMenu.getPlayerCount() == 3) { selectedChariot = LoadoutManager2.getChariot(1); }
            else if (Controller_playersMenu.getPlayerCount() == 4) { selectedChariot = LoadoutManager3.getChariot(1); }
        }
        else if (Player_Controller.getPlayerNumber() == 2)
        {
            if (Controller_playersMenu.getPlayerCount() == 2) { selectedChariot = LoadoutManager1.getChariot(2); }
            else if (Controller_playersMenu.getPlayerCount() == 3) { selectedChariot = LoadoutManager2.getChariot(2); }
            else if (Controller_playersMenu.getPlayerCount() == 4) { selectedChariot = LoadoutManager3.getChariot(2); }
        }
        else if (Player_Controller.getPlayerNumber() == 3)
        {
            if (Controller_playersMenu.getPlayerCount() == 3) { selectedChariot = LoadoutManager2.getChariot(3); }
            else if (Controller_playersMenu.getPlayerCount() == 4) { selectedChariot = LoadoutManager3.getChariot(3); }
        }
        else if (Player_Controller.getPlayerNumber() == 4) { selectedChariot = LoadoutManager3.getChariot(4); }
    }

    void computeChariotDefense()
    {
        if (selectedChariot == 0)
        {
            chariotDefense = 5;
            hitboxSize = 0;
        }

        else if (selectedChariot == 1)
        {
            chariotDefense = 10;
            hitboxSize = 1;
        }

        else if (selectedChariot == 2)
        {
            chariotDefense = 15;
            hitboxSize = 3;
        }
    }

    public int returnChariot() { return selectedChariot; }
}
