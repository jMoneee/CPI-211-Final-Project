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
    public AudioSource musicPlayer;

    Animator animator;


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
    }

    // Update is called once per frame
    void Update()
    {
        LoadoutUpdate();

        if (this.transform.position.y <= -30)
        { this.transform.parent.GetComponentInParent<Player_Controller>().Die(); }

        //Debug.Log("Speed timer is at: " + speedBoostTimer);
        if (speedBoostTimer >= 0)
        {
            speedBoostTimer -= Time.deltaTime;
            animal_speed = base_speed * 5;
        }
        else if(speedBoostTimer <= 0)
        {
            animal_speed = base_speed;
        }
    }

    void FixedUpdate()
    {
        var turn = Input.GetAxis(("" + player + "_Horizontal"));
        // Debug.Log(turn);
        var accelerate = Input.GetAxis(("" + player + "_Vertical"));
        if(accelerate <= 0)
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
                wheel_right.transform.Rotate(0, 0, -10 * animal_speed * Time.deltaTime);
                wheel_left.transform.Rotate(0, 0, 10 * (animal_speed) * (Time.deltaTime));
                animator.SetBool("Forward", true);
                animator.SetBool("Still", false);
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
                Destroy(other.gameObject);
            }

        }
        if(other.CompareTag("Speed"))
        {
            IngameSoundManager.PlaySound("pickup");
            Debug.Log("Speed Boost activated");
            speedBoostTimer += 10;
            Destroy(other.gameObject);
        }
    }

    void LoadoutUpdate()
    {
        if (this.gameObject.GetComponent<HorseManager>().returnHorse() == 0)
        {
            //fill in values for horse
        }

        else if (this.gameObject.GetComponent<HorseManager>().returnHorse() == 1)
        {
            //fill in values for bear
        }

        else if (this.gameObject.GetComponent<HorseManager>().returnHorse() == 2)
        {
            //fill in values for wolf
        }
    }
}


