
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseManager1 : MonoBehaviour
{
    //used for player 2 object
    public int selectedHorse = LoadoutManager.getP2animal();
    // Use this for initialization
    void Start()
    {
        selectedHorse = LoadoutManager.getP2animal();
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
