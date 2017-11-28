using System.Collections;
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
        Physics.IgnoreLayerCollision(8, 8, true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("" + playerID + "_Fire2"))
        {
            Debug.Log("Mouse click detected, entering damage conditional");
            SoundManager.PlaySound("swing");
            
            //if input ... 
            //do damage
            Debug.Log(collision);
            if (active)
            {
                Debug.Log("Right Active!");

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
        Debug.Log("Right triggered!!");
        active = true;



        Debug.Log("Gameobject: " + other.gameObject);

        collision = other.gameObject;
        Debug.Log("Collision: " + collision);
    }



    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Right Inactive!");
        active = false;
        collision = null;
    }

}
