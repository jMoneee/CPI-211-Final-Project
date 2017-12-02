
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseManager2 : MonoBehaviour
{
    //used for player 3
    public int selectedHorse = LoadoutManager.getP3animal();
    // Use this for initialization
    void Start()
    {
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
