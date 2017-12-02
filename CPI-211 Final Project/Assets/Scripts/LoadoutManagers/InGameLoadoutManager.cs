using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameLoadoutManager : MonoBehaviour {
    public static int InGamep1chariot;
    public int InGamep1animal;
    public int InGamep2chariot;
    public int InGamep2animal;
    public int InGamep3chariot;
    public int InGamep3animal;
    public int InGamep4chariot;
    public int InGamep4animal;

    // Use this for initialization
    void Start () {
        InGamep1chariot = LoadoutManager.getP1chariot();
        InGamep1chariot = LoadoutManager.getP1chariot();
        InGamep2chariot = LoadoutManager.getP2chariot();
        InGamep2chariot = LoadoutManager.getP2chariot();
        if (Controller_playersMenu.getPlayerCount() > 3)
        {
            InGamep3chariot = LoadoutManager.getP3chariot();
            InGamep3chariot = LoadoutManager.getP3chariot();
        }
        if (Controller_playersMenu.getPlayerCount() == 4)
        {
            InGamep4chariot = LoadoutManager.getP4chariot();
            InGamep4chariot = LoadoutManager.getP4chariot();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
