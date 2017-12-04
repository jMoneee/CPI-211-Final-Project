using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {

    public Transform theWeapon;
    public int selectedWeapon;
    public float wepDamage;
    public float wepSpeed;

    public GameObject player;

    // Use this for initialization
    void Start()
    {
        getWeapon();

        theWeapon = this.transform.GetChild(selectedWeapon);
        theWeapon.gameObject.SetActive(true);

        computeWeaponStats();
        player.GetComponent<Player_Controller>().setWeaponStats(wepDamage, wepSpeed);
    }

    void getWeapon()
    {
        if (Player_Controller.getPlayerNumber() == 1)
        {
            if (Controller_playersMenu.getPlayerCount() == 2) { selectedWeapon = LoadoutManager1.getWeapon(1); }
            else if (Controller_playersMenu.getPlayerCount() == 3) { selectedWeapon = LoadoutManager2.getWeapon(1); }
            else if (Controller_playersMenu.getPlayerCount() == 4) { selectedWeapon = LoadoutManager3.getWeapon(1); }
        }
        else if (Player_Controller.getPlayerNumber() == 2)
        {
            if (Controller_playersMenu.getPlayerCount() == 2) { selectedWeapon = LoadoutManager1.getWeapon(2); }
            else if (Controller_playersMenu.getPlayerCount() == 3) { selectedWeapon = LoadoutManager2.getWeapon(2); }
            else if (Controller_playersMenu.getPlayerCount() == 4) { selectedWeapon = LoadoutManager3.getWeapon(2); }
        }
        else if (Player_Controller.getPlayerNumber() == 3)
        {
            if (Controller_playersMenu.getPlayerCount() == 3) { selectedWeapon = LoadoutManager2.getWeapon(3); }
            else if (Controller_playersMenu.getPlayerCount() == 4) { selectedWeapon = LoadoutManager3.getWeapon(3); }
        }
        else if (Player_Controller.getPlayerNumber() == 4) { selectedWeapon = LoadoutManager3.getWeapon(4); }
    }

    void computeWeaponStats()
    {
        if (selectedWeapon == 0)
        {
            wepDamage = 35f;
            wepSpeed = 3f;
        }

        else if (selectedWeapon == 1)
        {
            wepDamage = 45f;
            wepSpeed = 10f;
        }

        else if (selectedWeapon == 2)
        {
            wepDamage = 40f;
            wepSpeed = 5f;
        }

        else if (selectedWeapon == 3)
        {
            wepDamage = 30f;
            wepSpeed = 1f;
        }
    }
}
