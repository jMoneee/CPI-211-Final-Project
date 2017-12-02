
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseManager3 : MonoBehaviour
{
    //used for Player4
    public int selectedHorse = LoadoutManager.getP4animal();
    // Use this for initialization
    void Start()
    {
        selectedHorse = LoadoutManager.getP4animal();
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
