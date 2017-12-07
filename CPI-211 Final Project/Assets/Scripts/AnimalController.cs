using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    //This script uses player input to cause the animal to start moving.
    // Created by Brandon Bayles
    //

    // Use this for initialization
    public float animal_speed;
    public float base_speed;
    public float turn_speed;
    private Rigidbody myRigidBody;
    public GameObject wheel_left;
    public GameObject wheel_right;
    private float speedBoostTimer;
    private float speedReductTimer;
    private float shieldTimer;
    public AudioSource musicPlayer;
    public GameObject net;
    public GameObject caltrops;
    public GameObject shield;
    public bool invincible;
    private float player_defense;

    Animator animator;

    public int deployablePickup; //used to determine when player has pickup and what pickup they have
    // 0 indicates no pickup, 1 indicates net, 2 indicates caltrops

    public string player;

    void Start()
    {
        if (this.transform.parent.parent.name == "Player 1") { player = "P1"; }
        if (this.transform.parent.parent.name == "Player 2") { player = "P2"; }
        if (this.transform.parent.parent.name == "Player 3") { player = "P3"; }
        if (this.transform.parent.parent.name == "Player 4") { player = "P4"; }

        myRigidBody = GetComponent<Rigidbody>();
        speedBoostTimer = 0f;
        base_speed = animal_speed;
        animator = GetComponent<Animator>();
        animator.SetBool("Still", true);
        animator.SetBool("Forward", false);
        shieldTimer = 0f;
        invincible = false;
        player_defense = GetComponentInParent<Player_Controller>().defense;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Speed timer is at: " + speedBoostTimer);
        CheckSpeedBoost();
        CheckSpeedReduction();
        if(shieldTimer > 0)
        {
            invincible = true;
            shieldTimer -= Time.deltaTime;
            GetComponentInParent<Player_Controller>().defense = 200f;
        }
        else
        {
            invincible = false;
            GetComponentInParent<Player_Controller>().defense = player_defense;
        }
        if (Input.GetButton("P" + this.transform.parent.GetComponentInParent<Player_Controller>().getPlayerNumberN() + "_Fire3") && deployablePickup != 0)
        {
            switch (deployablePickup)
            {
                case 1: //net picked up
                    Object netDeployed = Instantiate(net, new Vector3(this.transform.position.x, 8.5f, this.transform.position.z), Quaternion.identity);
                    deployablePickup = 0;
                    break;

                case 2: //caltrops picked up
                    Object caltropsDeplyed = Instantiate(caltrops, new Vector3(this.transform.position.x, -4.5f, this.transform.position.z), Quaternion.identity);
                    deployablePickup = 0;
                    break;
                case 3: //shield picked up
                    Object shieldDeployed = Instantiate(shield, this.transform, false);
                    shieldTimer += 15f;
                    deployablePickup = 0;
                    break;
            }
        }
    }

    void FixedUpdate()
    {
        var turn = Input.GetAxis(("" + player + "_Horizontal"));
        // Debug.Log(turn);
        var accelerate = Input.GetAxis(("" + player + "_Vertical"));
        if(accelerate < 0)
        {
            animator.SetBool("Still", true);
            animator.SetBool("Forward", false);
        }
        if (accelerate >= 0)
        {
           
            var moveDist = accelerate * animal_speed * Time.deltaTime;
            var turnAngle = (turn * turn_speed) * Time.deltaTime;
            // Debug.Log("turn angle: " +turnAngle);
            transform.Rotate(0, turnAngle, 0);
            transform.Translate(Vector3.forward * moveDist);
            if (accelerate > 0)
            {
                animator.SetBool("Forward", true);
                animator.SetBool("Still", false);
                wheel_right.transform.Rotate(0, 0, -10 * animal_speed * Time.deltaTime);
                wheel_left.transform.Rotate(0, 0, 10 * (animal_speed) * (Time.deltaTime));
               
            }
        }
        //  else if (accelerate <0)           reverse direction was causing animal to be flipped. I disabled it, but left in case we decide to bring it back
        //{
        //  var moveDist = accelerate * animal_speed * Time.deltaTime;
        //var turnAngle = turn * turn_speed * Time.deltaTime;
        //transform.Rotate(0, 0, turnAngle);
        //transform.Translate(Vector3.forward * moveDist);
        //wheel_right.transform.Rotate(0, 0, 10 * animal_speed * Time.deltaTime);
        //wheel_left.transform.Rotate(0, 0, -10 * (animal_speed) * (Time.deltaTime));
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Health"))
        {
            if (GetComponentInParent<Player_Controller>().currentHealth < GetComponentInParent<Player_Controller>().maxHealth)
            {
                IngameSoundManager.PlaySound("pickup");
                GetComponentInParent<Player_Controller>().Heal();
                StartCoroutine(tempDestroy(other.gameObject, 5));
                // Destroy(other.gameObject);
            }

        }
        if(other.CompareTag("Speed"))
        {
            IngameSoundManager.PlaySound("pickup");
            Debug.Log("Speed Boost activated");
            speedBoostTimer = 10;
            StartCoroutine(tempDestroy(other.gameObject, 5));
            //Destroy(other.gameObject);
        }

        if (other.CompareTag("Net_Pickup"))
        {
            IngameSoundManager.PlaySound("pickup");
            Debug.Log("Net picked up");
            deployablePickup = 1;
            StartCoroutine(tempDestroy(other.gameObject, 5));
        }

        if (other.CompareTag("Net_Deployed"))
        {
            Debug.Log("Netted!");
            speedReductTimer = 5;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Caltrops_Pickup"))
        {
            IngameSoundManager.PlaySound("pickup");
            Debug.Log("Caltrops picked up");
            deployablePickup = 2;
            StartCoroutine(tempDestroy(other.gameObject, 5));
        }

        if (other.CompareTag("Caltrops_Deployed") && invincible == false)
        {
            Debug.Log("Caltrops run over!");
            this.transform.parent.GetComponentInParent<Player_Controller>().reduceHealth(15);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Shield_pickup"))
        {
            IngameSoundManager.PlaySound("pickup");
            Debug.Log("Shield picked up");
            deployablePickup = 3;
            StartCoroutine(tempDestroy(other.gameObject, 5));
        }
    }

    void CheckSpeedBoost()
    {
        if (speedBoostTimer >= 0)
        {
            speedBoostTimer -= Time.deltaTime;
            animal_speed = base_speed * 5;
        }
        else if (speedBoostTimer <= 0)
        {
            animal_speed = base_speed;
        }
    }

    void CheckSpeedReduction()
    {
        if (speedReductTimer >= 0)
        {
            speedReductTimer -= Time.deltaTime;
            animal_speed = 5;
        }
        else if (speedReductTimer <= 0 && speedBoostTimer <= 0)
        {
            animal_speed = base_speed;
        }
    }

    IEnumerator tempDestroy(GameObject obj, float respawnTime)
    {
        obj.SetActive(false);
        yield return new WaitForSeconds(respawnTime);
        obj.SetActive(true);
        

    }
    
    public int getPickup() { return deployablePickup; }
}


