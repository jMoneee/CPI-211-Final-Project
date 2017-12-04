
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseManager : MonoBehaviour
{
    //used for Player 1 object
    public int selectedHorse;
    // Use this for initialization
    void Start()
    {
        if (Player_Controller.getPlayerNumber() == 1) { selectedHorse = LoadoutManager.getP1animal(); }
        else if (Player_Controller.getPlayerNumber() == 2) { selectedHorse = LoadoutManager.getP2animal(); }
        else if (Player_Controller.getPlayerNumber() == 3) { selectedHorse = LoadoutManager.getP3animal(); }
        else if (Player_Controller.getPlayerNumber() == 4) { selectedHorse = LoadoutManager.getP4animal(); }
        SelectHorse();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void SelectHorse()
    {
        int i = 0;
        foreach (Transform chariot in transform)
        {
            if (i == selectedHorse)
            {
                chariot.gameObject.SetActive(true);
            }
            else
            {
                chariot.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
