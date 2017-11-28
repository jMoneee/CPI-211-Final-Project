using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChariotManager : MonoBehaviour {

    public int selectedChariot = 0;
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
