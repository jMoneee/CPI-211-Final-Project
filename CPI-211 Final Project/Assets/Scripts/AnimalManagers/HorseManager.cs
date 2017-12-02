
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
        selectedHorse = LoadoutManager.getP1animal();
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
