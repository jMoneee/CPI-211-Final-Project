using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChariotManager1 : MonoBehaviour {
    //use this for player 2
    public int selectedChariot = LoadoutManager.getP2chariot();
    // Use this for initialization
    void Start() {
        SelectChariot();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void SelectChariot()
    {
        int i = 0;
        foreach(Transform chariot in transform)
        {
            if (i == selectedChariot)
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
