using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Left : MonoBehaviour
{
    private bool active;//flag for when something is within melee range
    private GameObject collision;//variable for collider within melee range
    public GameObject player;
    public float attackTime;//time between swings, when != 0, the player cannot swing
    public float weaponSpeed;//the amount of time added to attackTime after a player swings. EDIT THIS VALUE TO CHANGE ATTACK SPEED, IT SHOULD BE RELATIVE TO THE WEAPON USED

    public string playerID = "P1";
    // Use this for initialization
    void Start()
    {
        active = false;
        Physics.IgnoreLayerCollision(8,8,true );
        attackTime = 0;

    }

    // Update is called once per frame
    void Update()
    {
        attackTime -= Time.deltaTime;
        if (Input.GetButton("" + playerID + "_Fire1") && attackTime <= 0)
        {
            Debug.Log("Mouse click detected, entering damage conditional");
            
            SoundManager.PlaySound("swing");
            attackTime += weaponSpeed;
            //if input ... 
            //check hitbox
            
            if (active)
            {
                Debug.Log("Left Active!");
                Debug.Log(collision);
                if (collision.CompareTag("Player"))
                {
                    collision.GetComponent<Player_Controller>().currentHealth -= (int)player.GetComponent<Player_Controller>().getDamage(); //for now I guess
                    Debug.Log("DAMAGE!! YEAH!");
                    SoundManager.PlaySound("damage");
                }
                else if (collision.CompareTag("Horse") || collision.CompareTag("Chariot"))
                {
                    collision.GetComponentInParent<Player_Controller>().currentHealth -= (int)player.GetComponent<Player_Controller>().getDamage(); //for now I guess
                    Debug.Log("DAMAGE!! YEAH!");
                    SoundManager.PlaySound("damage");
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Left triggered!!");
        active = true;

        

        Debug.Log("Gameobject: " + other.gameObject);
       
            collision = other.gameObject;
            Debug.Log("Collision: " + collision);
      
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Left Inactive!");
        active = false;
        collision = null;
    }

}

