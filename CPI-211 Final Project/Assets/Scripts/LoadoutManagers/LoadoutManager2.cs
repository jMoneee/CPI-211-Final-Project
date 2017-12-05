using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//use for 3 player canvas
public class LoadoutManager2 : MonoBehaviour
{
    public static int P1chariot = 0;
    public static int P1animal = 0;
    public static int P1weapon = 0;
    public static int P2chariot = 0;
    public static int P2animal = 0;
    public static int P2weapon = 0;
    public static int P3chariot = 0;
    public static int P3animal = 0;
    public static int P3weapon = 0;

    public Transform P1chariotDropdown;
    public Transform P1animalDropdown;
    public Transform P1weaponDropdown;
    public Transform P2chariotDropdown;
    public Transform P2animalDropdown;
    public Transform P2weaponDropdown;
    public Transform P3chariotDropdown;
    public Transform P3animalDropdown;
    public Transform P3weaponDropdown;



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


        P3chariot = P3chariotDropdown.GetComponent<Dropdown>().value;
        P3animal = P3animalDropdown.GetComponent<Dropdown>().value;
        P3weapon = P3weaponDropdown.GetComponent<Dropdown>().value;

        LoadoutManager.setP3animal(P3animal);
        LoadoutManager.setP3chariot(P3chariot);
        LoadoutManager.setP3weapon(P3weapon);

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

            case 3:
                return P3chariot;
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

            case 3:
                return P3animal;
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

            case 3:
                return P3weapon;
                break;
        }

        return 0;
    }

}
