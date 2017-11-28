using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadoutPlayersSelect : MonoBehaviour {

    public GameObject TwoPCanvas;
    public GameObject ThreePCanvas;
    public GameObject FourPCanvas;

    // Use this for initialization
    void Start ()
    {
		if (Controller_playersMenu.getPlayerCount() == 2) { TwoPCanvas.SetActive(true); }
        else if (Controller_playersMenu.getPlayerCount() == 3) { ThreePCanvas.SetActive(true); }
        else if (Controller_playersMenu.getPlayerCount() == 4) { FourPCanvas.SetActive(true); }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
