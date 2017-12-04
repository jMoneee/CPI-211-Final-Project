﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//use for 2 player canvas
public class LoadoutManager1 : MonoBehaviour
{
    public static int P1chariot = 0;
    public static int P1animal = 0;
    public static int P1weapon = 0;
    public static int P2chariot = 0;
    public static int P2animal = 0;
    public static int P2weapon = 0;

    public Transform P1chariotDropdown;
    public Transform P1animalDropdown;
    public Transform P1weaponDropdown;
    public Transform P2chariotDropdown;
    public Transform P2animalDropdown;
    public Transform P2weaponDropdown;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
        P1chariot = P1chariotDropdown.GetComponent<Dropdown>().value;
        P1animal = P1animalDropdown.GetComponent<Dropdown>().value;
        P1weapon = P1weaponDropdown.GetComponent<Dropdown>().value;

        LoadoutManager.setP1animal(P1animal);
        LoadoutManager.setP1chariot(P1chariot);
        LoadoutManager.setP1weapon(P1weapon);


        P2chariot = P2chariotDropdown.GetComponent<Dropdown>().value;
        P2animal = P2animalDropdown.GetComponent<Dropdown>().value;
        P2weapon = P2weaponDropdown.GetComponent<Dropdown>().value;

        LoadoutManager.setP2animal(P2animal);
        LoadoutManager.setP2chariot(P2chariot);
        LoadoutManager.setP2weapon(P2weapon);

    }

    public static int getChariot(int i)
    {
        switch (i)
        {
            case 1:
                return P1chariot;
                break;

            case 2:
                return P2chariot;
                break;
        }

        return 0;
    }

    public static int getAnimal(int i)
    {
        switch (i)
        {
            case 1:
                return P1animal;
                break;

            case 2:
                return P2animal;
                break;
        }

        return 0;
    }

    public static int getWeapon(int i)
    {
        switch (i)
        {
            case 1:
                return P1weapon;
                break;

            case 2:
                return P2weapon;
                break;
        }

        return 0;
    }
}
