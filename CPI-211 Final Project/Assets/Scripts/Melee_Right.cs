using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Right : MonoBehaviour
{
    private bool active;
    private GameObject collision;
    public GameObject player;
    private float attackTime;//attacktime tracks how much time is left till player can swing again
    public float attackSpeed;//EDIT THIS TO CHANGE HOW LONG IT TAKES BETWEEN SWINGS
    public float damage;
    public int damageDealt;
    public Animator playerAnimator;//put the appropriate player animator here in-engine for combat animation
    public Animator[] animatorOptions;


    public string playerID;
    // Use this for initialization
    void Start()
    {
        setWeaponObjects();
        player = this.transform.parent.parent.parent.gameObject;
        playerID = "P" + player.GetComponent<Player_Controller>().getPlayerNumberN();

        active = false;
        Physics.IgnoreLayerCollision(8, 8, true);
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
        if (Input.GetButton("" + playerID + "_Fire2") && attackTime <= 0)
        {
            attackTime += attackSpeed;
            //playerAnimator.SetBool("still", false);
            //playerAnimator.SetBool("attack_left", false);
            //playerAnimator.SetBool("attack_right", true);
            playerAnimator.Play("Attack_right", 0);

            Debug.Log("Mouse click detected, entering damage conditional");
            IngameSoundManager.PlaySound("swing");
            
            //if input ... 
            //do damage
           // Debug.Log(collision);
            if (active)
            {
               // Debug.Log("Right Active!");

                if (collision.CompareTag("Player"))
                {
                    damageDealt = (int)damage - (int)collision.GetComponent<Player_Controller>().getDefense();
                    collision.GetComponent<Player_Controller>().currentHealth -= damageDealt; //for now I guess
                    Debug.Log("DAMAGE!! YEAH!");
                    SoundManager.PlaySound("damage");
                }
                else if (collision.CompareTag("Horse") || collision.CompareTag("Chariot"))
                {
                    damageDealt = (int)damage - (int)collision.GetComponentInParent<Player_Controller>().getDefense();
                    collision.GetComponentInParent<Player_Controller>().currentHealth -= damageDealt; //for now I guess
                    Debug.Log("DAMAGE!! YEAH!");
                    SoundManager.PlaySound("damage");
                }
            }
        }

    }
    private void LateUpdate()
    {
       // playerAnimator.SetBool("still", true);
        //playerAnimator.SetBool("attack_left", false);
       // playerAnimator.SetBool("attack_right", false);
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Right triggered!!");
        active = true;



       // Debug.Log("Gameobject: " + other.gameObject);

        collision = other.gameObject;
       // Debug.Log("Collision: " + collision);
    }



    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Right Inactive!");
        active = false;
        collision = null;
    }

    void setWeaponObjects()
    {
        int player = this.transform.parent.parent.GetComponentInParent<Player_Controller>().getPlayerNumberN();
        int totalPlayers = Controller_playersMenu.getPlayerCount();

        int selectedWeapon = 0;

        #region GetWeapon
        if (player == 1)
        {
            if (totalPlayers == 2) { selectedWeapon = LoadoutManager1.getWeapon(1); }
            else if (totalPlayers == 3) { selectedWeapon = LoadoutManager2.getWeapon(1); }
            else if (totalPlayers == 4) { selectedWeapon = LoadoutManager3.getWeapon(1); }
        }
        else if (player == 2)
        {
            if (totalPlayers == 2) { selectedWeapon = LoadoutManager1.getWeapon(2); }
            else if (totalPlayers == 3) { selectedWeapon = LoadoutManager2.getWeapon(2); }
            else if (totalPlayers == 4) { selectedWeapon = LoadoutManager3.getWeapon(2); }
        }
        else if (player == 3)
        {
            if (totalPlayers == 3) { selectedWeapon = LoadoutManager2.getWeapon(3); }
            else if (totalPlayers == 4) { selectedWeapon = LoadoutManager3.getWeapon(3); }
        }
        else if (player == 4) { selectedWeapon = LoadoutManager3.getWeapon(4); }
        #endregion

        switch (selectedWeapon)
        {
            case 0:
                {
                    playerAnimator = animatorOptions[0];
                    attackSpeed = 3f;
                    damage = 35f;
                    break;
                }

            case 1:
                {
                    playerAnimator = animatorOptions[1];
                    attackSpeed = 6f;
                    damage = 45f;
                    break;
                }

            case 2:
                {
                    playerAnimator = animatorOptions[2];
                    attackSpeed = 4f;
                    damage = 40f;
                    break;
                }

            case 3:
                {
                    playerAnimator = animatorOptions[3];
                    attackSpeed = 1f;
                    damage = 30f;
                    break;
                }
        }
    }

}
