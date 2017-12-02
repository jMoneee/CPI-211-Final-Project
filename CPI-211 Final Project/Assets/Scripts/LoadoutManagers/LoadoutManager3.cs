﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//use for 4 player canvas
public class LoadoutManager3 : MonoBehaviour
{
    private int P1chariot = 0;
    private int P1animal = 0;
    private int P2chariot = 0;
    private int P2animal = 0;
    private int P3chariot = 0;
    private int P3animal = 0;
    private int P4chariot = 0;
    private int P4animal = 0;

    public Transform P1chariotDropdown;
    public Transform P1animalDropdown;
    public Transform P2chariotDropdown;
    public Transform P2animalDropdown;
    public Transform P3chariotDropdown;
    public Transform P3animalDropdown;
    public Transform P4chariotDropdown;
    public Transform P4animalDropdown;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        P1chariot = P1chariotDropdown.GetComponent<Dropdown>().value;
        P1animal = P1animalDropdown.GetComponent<Dropdown>().value;

        LoadoutManager.setP1animal(P1animal);
        LoadoutManager.setP1chariot(P1chariot);

        P2chariot = P2chariotDropdown.GetComponent<Dropdown>().value;
        P2animal = P2animalDropdown.GetComponent<Dropdown>().value;

        LoadoutManager.setP2animal(P2animal);
        LoadoutManager.setP2chariot(P2chariot);

        P3chariot = P3chariotDropdown.GetComponent<Dropdown>().value;
        P3animal = P3animalDropdown.GetComponent<Dropdown>().value;

        LoadoutManager.setP3animal(P3animal);
        LoadoutManager.setP3chariot(P3chariot);

        P2chariot = P4chariotDropdown.GetComponent<Dropdown>().value;
        P2animal = P4animalDropdown.GetComponent<Dropdown>().value;

        LoadoutManager.setP4animal(P4animal);
        LoadoutManager.setP4chariot(P4chariot);


    }
}