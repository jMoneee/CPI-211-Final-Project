using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChariotManager2 : MonoBehaviour {
    //use this for player 3
    public int selectedChariot = LoadoutManager.getP3chariot();
    // Use this for initialization
    void Start() {
        selectedChariot = LoadoutManager.getP3chariot();
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
