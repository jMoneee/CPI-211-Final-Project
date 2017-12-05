using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{

    // Controls the character's stats and detects pickup collisions
    // Made by Brandon Bayles
    public Collider animalCollider;//animal's hitbox
    public Collider ChariotCollider;//chariot's hitbox
    public int maxHealth = 100;//player's maximum health
    public int animalSpeed;//animal's speed, dependent on animal type
    public int currentHealth;//current HP
    public int healthBoost = 30;//the amount of HP restored by hitting a health pack

    public float damage;//damage, calculated based on weapon
    public float defense;//defense from damage, calculated based on chariot
    public float swingTimer;//time between swings, calculated based on weapon
    public float hitboxSize;//size of hitboxes, calculated based on chariot

    public int placement;
    public int playerNumberN;
    public static int playerNumber;

    public Slider healthSlider;//health bar
    public Slider[] healthSliderOptions;

    public GameObject animal;

    void Start()
    {
        if (this.gameObject.name == "Player 1") { playerNumber = 1; }
        else if (this.gameObject.name == "Player 2") { playerNumber = 2; }
        else if (this.gameObject.name == "Player 3") { playerNumber = 3; }
        else if (this.gameObject.name == "Player 4") { playerNumber = 4; }
        playerNumberN = playerNumber;

        determineHealthSlider();

        setPlacement(0);
        currentHealth = maxHealth;
        damage = 10;//temporary, to be replaced later
        //eventually use the enums assigned to player to populate stats
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
        //Vector3 newPos = Vector3.MoveTowards(transform.forward, animal.transform.forward, 0);
        //transform.Translate(newPos);
        healthSlider.value = currentHealth;
    }
    public void Heal()
    {

        Debug.Log("Entered health conditional");
        if (currentHealth != maxHealth)
        {

            Debug.Log("Health is less than full, activating health pack!");
            if (currentHealth <= maxHealth - healthBoost)
            {
                currentHealth += healthBoost;//healthboost wont bring back to full
            }
            else
            {
                currentHealth = maxHealth;//healthboost brings back to full
            }
        }
    }

    public void Die()
    {
        setPlacement(GameManager_colosseum.getCurrentPlayers());
        this.gameObject.SetActive(false);
    }

    public void determineHealthSlider()
    {
        if (Controller_playersMenu.getPlayerCount() == 2)
        {
            switch (LoadoutManager1.getAnimal(playerNumber))
            {
                case 0:
                    if (playerNumber == 1)
                    {
                        healthSlider = healthSliderOptions[0];
                    }

                    else if (playerNumber == 2)
                    {
                        healthSlider = healthSliderOptions[2];
                    }
                    break;

                case 1:
                    if (playerNumber == 1)
                    {
                        healthSlider = healthSliderOptions[6];
                    }

                    else if (playerNumber == 2)
                    {
                        healthSlider = healthSliderOptions[8];
                    }
                    break;

                case 2:
                    if (playerNumber == 1)
                    {
                        healthSlider = healthSliderOptions[12];
                    }

                    else if (playerNumber == 2)
                    {
                        healthSlider = healthSliderOptions[14];
                    }
                    break;
            }
        }

        else if (Controller_playersMenu.getPlayerCount() == 3)
        {
            switch (LoadoutManager1.getAnimal(playerNumber))
            {
                case 0:
                    if (playerNumber == 1)
                    {
                        healthSlider = healthSliderOptions[1];
                    }

                    else if (playerNumber == 2)
                    {
                        healthSlider = healthSliderOptions[3];
                    }

                    else if (playerNumber == 3)
                    {
                        healthSlider = healthSliderOptions[4];
                    }
                    break;

                case 1:
                    if (playerNumber == 1)
                    {
                        healthSlider = healthSliderOptions[7];
                    }

                    else if (playerNumber == 2)
                    {
                        healthSlider = healthSliderOptions[9];
                    }

                    else if (playerNumber == 3)
                    {
                        healthSlider = healthSliderOptions[10];
                    }
                    break;

                case 2:
                    if (playerNumber == 1)
                    {
                        healthSlider = healthSliderOptions[13];
                    }

                    else if (playerNumber == 2)
                    {
                        healthSlider = healthSliderOptions[15];
                    }

                    else if (playerNumber == 3)
                    {
                        healthSlider = healthSliderOptions[16];
                    }
                    break;
            }
        }

        else if (Controller_playersMenu.getPlayerCount() == 4)
        {
            switch (LoadoutManager1.getAnimal(playerNumber))
            {
                case 0:
                    if (playerNumber == 1)
                    {
                        healthSlider = healthSliderOptions[1];
                    }

                    else if (playerNumber == 2)
                    {
                        healthSlider = healthSliderOptions[3];
                    }

                    else if (playerNumber == 3)
                    {
                        healthSlider = healthSliderOptions[4];
                    }

                    else if (playerNumber == 3)
                    {
                        healthSlider = healthSliderOptions[5];
                    }
                    break;

                case 1:
                    if (playerNumber == 1)
                    {
                        healthSlider = healthSliderOptions[7];
                    }

                    else if (playerNumber == 2)
                    {
                        healthSlider = healthSliderOptions[9];
                    }

                    else if (playerNumber == 3)
                    {
                        healthSlider = healthSliderOptions[10];
                    }

                    else if (playerNumber == 3)
                    {
                        healthSlider = healthSliderOptions[11];
                    }
                    break;

                case 2:
                    if (playerNumber == 1)
                    {
                        healthSlider = healthSliderOptions[13];
                    }

                    else if (playerNumber == 2)
                    {
                        healthSlider = healthSliderOptions[15];
                    }

                    else if (playerNumber == 3)
                    {
                        healthSlider = healthSliderOptions[16];
                    }

                    else if (playerNumber == 3)
                    {
                        healthSlider = healthSliderOptions[17];
                    }
                    break;
            }
        }
    }

    public void setChariotStats(float _defense, int _hitboxSize)
    {
        defense = _defense;
        hitboxSize = _hitboxSize;
    }

    public void setWeaponStats(float _damage, float _swingTimer)
    {
        damage = _damage;
        swingTimer = _swingTimer;
    }

    public float getDamage()//returns damage
    { return damage;  }

    public int getPlacement() { return placement; }
    public void setPlacement(int place) { placement = place; }
    public static int getPlayerNumber() { return playerNumber; }
    public int getPlayerNumberN() { return playerNumberN; }

    public void setUpSlider(Slider _healthSlider) { healthSlider = _healthSlider; }

}
