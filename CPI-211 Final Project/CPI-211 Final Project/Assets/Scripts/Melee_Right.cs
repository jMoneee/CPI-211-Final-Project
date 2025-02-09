﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Right : MonoBehaviour
{
    private bool active;
    private GameObject collision;
    public GameObject player;

    public string playerID = "P1";
    // Use this for initialization
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            //if input ... 
            //do damage
            Debug.Log(collision);
            if (Input.GetButton(""+playerID + "_Fire2"))
            {
                collision.GetComponent<Player_Controller>().currentHealth -= (int)player.GetComponent<Player_Controller>().getDamage(); //for now I guess
                Debug.Log("DAMAGE!! YEAH!");
                SoundManager.PlaySound("damage");
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Right triggered!!");
        active = true;

        SoundManager.PlaySound("swing");

        Debug.Log("Conditional right Called... checking for player tag");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Attacking Right!");
            collision = other.gameObject;
            Debug.Log(collision);
        }
    }



    private void OnTriggerExit(Collider other)
    {
        active = false;
        collision = null;
    }

}
