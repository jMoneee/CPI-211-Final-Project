using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Left : MonoBehaviour
{
    private bool active;
    private GameObject collision;
    public GameObject player;
    private float attackTime;//attacktime tracks how much time is left till player can swing again
    public float attackSpeed;//EDIT THIS TO CHANGE HOW LONG IT TAKES BETWEEN SWINGS
    public Animator playerAnimator;//put the appropriate player animator here in-engine for combat animation

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
        Debug.Log("attack time is: " + attackTime);
        if (attackTime > 0)
        {
            attackTime -= Time.deltaTime;
        }
        if (Input.GetButton("" + playerID + "_Fire1") && attackTime <= 0)
        {
            attackTime += attackSpeed;
            //playerAnimator.SetBool("still", false);
            //playerAnimator.SetBool("attack_left", true);
            //playerAnimator.SetBool("attack_right", false);
            playerAnimator.Play("Attack_left", 0);

            Debug.Log("Mouse click detected, entering damage conditional");
            IngameSoundManager.PlaySound("swing");
            //if input ... 
            //do damage
           // Debug.Log(collision);
          
            if (active)
                {
                   // Debug.Log("Left Active!");
                    if (collision.CompareTag("Player"))
                {
                    collision.GetComponent<Player_Controller>().currentHealth -= (int)player.GetComponent<Player_Controller>().getDamage(); //for now I guess
                    Debug.Log("DAMAGE!! YEAH!");
                    SoundManager.PlaySound("damage");
                }
                else if (collision.CompareTag("Horse") || collision.CompareTag("Chariot"))
                {
                    collision.GetComponentInParent<Player_Controller>().currentHealth -= (int)player.GetComponent<Player_Controller>().getDamage(); //for now I guess
                   // Debug.Log("DAMAGE!! YEAH!");
                    SoundManager.PlaySound("damage");
                }
            }
        }
    }
    private void LateUpdate()
    {
        //playerAnimator.SetBool("still", true);
        //playerAnimator.Play("Attack_left", 0);
        //playerAnimator.SetBool("attack_right", false);
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Left triggered!!");
        active = true;

        

        //Debug.Log("Gameobject: " + other.gameObject);
       
            collision = other.gameObject;
            //Debug.Log("Collision: " + collision);
      
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Left Inactive!");
        active = false;
        collision = null;
    }

}

