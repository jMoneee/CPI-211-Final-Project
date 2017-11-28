using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour {

    // Controls the character's stats and detects pickup collisions
    // Made by Brandon Bayles
    public Collider animalCollider;//animal's hitbox
    public Collider ChariotCollider;//chariot's hitbox
    public int maxHealth = 100;//player's maximum health
    public int animalSpeed;//animal's speed, dependent on animal type
    public int currentHealth;//current HP
    public int healthBoost;//the amount of HP restored by hitting a health pack
    public float damage;//damage, calculated based on weapon

    public Slider healthSlider;//health bar
    public Slider staminaSlider;//temp, to be used when stamina is used

    public static AudioSource soundPlayer;//plays sounds
    public static AudioClip snd_swing;//sound of player swinging weapon
    public static AudioClip snd_damage;//sound of player hitting another player
    
	void Start () {
        currentHealth = maxHealth;
        damage = 10;//temporary, to be replaced later
        //eventually use the enums assigned to player to populate stats

        snd_swing = Resources.Load<AudioClip>("weapon_swing");
        snd_damage = Resources.Load<AudioClip>("damage");

        soundPlayer = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0)
        {
            Die();
        }

        healthSlider.value = currentHealth;
       
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
