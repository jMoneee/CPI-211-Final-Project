
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseManager : MonoBehaviour
{
    public Transform theHorse;
    public int selectedHorse;
    // Use this for initialization
    void Start()
    {
        getHorse();

        theHorse = this.transform.GetChild(selectedHorse);
        theHorse.gameObject.SetActive(true);
    }

    void getHorse()
    {
        if (Player_Controller.getPlayerNumber() == 1)
        {
            if (Controller_playersMenu.getPlayerCount() == 2) { selectedHorse = LoadoutManager1.getAnimal(1); }
            else if (Controller_playersMenu.getPlayerCount() == 3) { selectedHorse = LoadoutManager2.getAnimal(1); }
            else if (Controller_playersMenu.getPlayerCount() == 4) { selectedHorse = LoadoutManager3.getAnimal(1); }
        }
        else if (Player_Controller.getPlayerNumber() == 2)
        {
            if (Controller_playersMenu.getPlayerCount() == 2) { selectedHorse = LoadoutManager1.getAnimal(2); }
            else if (Controller_playersMenu.getPlayerCount() == 3) { selectedHorse = LoadoutManager2.getAnimal(2); }
            else if (Controller_playersMenu.getPlayerCount() == 4) { selectedHorse = LoadoutManager3.getAnimal(2); }
        }
        else if (Player_Controller.getPlayerNumber() == 3)
        {
            if (Controller_playersMenu.getPlayerCount() == 3) { selectedHorse = LoadoutManager2.getAnimal(3); }
            else if (Controller_playersMenu.getPlayerCount() == 4) { selectedHorse = LoadoutManager3.getAnimal(3); }
        }
        else if (Player_Controller.getPlayerNumber() == 4) { selectedHorse = LoadoutManager3.getAnimal(4); }
    }

    public int returnHorse() { return selectedHorse; }
}
