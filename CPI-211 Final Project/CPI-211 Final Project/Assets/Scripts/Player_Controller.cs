﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

    // Controls the character's stats and detects pickup collisions
    // Made by Brandon Bayles
    public Collider animalCollider;//animal's hitbox
    public Collider ChariotCollider;//chariot's hitbox
    public int maxHealth;//player's maximum health
    public int animalSpeed;//animal's speed, dependent on animal type
    public int currentHealth;//current HP
    public int healthBoost;//the amount of HP restored by hitting a health pack
    public float damage;//damage, calculated based on weapon
    
	void Start () {
        currentHealth = maxHealth;
        damage = 10;//temporary, to be replaced later
        //eventually use the enums assigned to player to populate stats
	}
	
	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0)
        {
            Die();
        }
       
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag ("Health"))
        {
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
    private void Die()
    {
        transform.position = Vector3.zero;
        currentHealth = maxHealth;
    }
    public float getDamage()//returns damage
    {
        return damage;
    }
   
}
