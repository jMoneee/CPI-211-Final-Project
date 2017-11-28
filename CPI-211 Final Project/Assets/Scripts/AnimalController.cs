using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour {
    //This script uses player input to cause the animal to start moving.
    // Created by Brandon Bayles
    //

        // Use this for initialization
        public float animal_speed;
        public float turn_speed;
        private Rigidbody myRigidBody;
        public GameObject wheel_left;
        public GameObject wheel_right;
        

        public string player = "P1";

        void Start()
        {
            myRigidBody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
                
        }

        void FixedUpdate()
        {
            var turn = Input.GetAxis((""+ player + "_Horizontal"));
            // Debug.Log(turn);
            var accelerate = Input.GetAxis(("" + player + "_Vertical"));
            if(accelerate >= 0)
            {
                var moveDist = accelerate * animal_speed * Time.deltaTime;
                var turnAngle = (turn * turn_speed) * Time.deltaTime;
               // Debug.Log("turn angle: " +turnAngle);
                transform.Rotate(0, turnAngle, 0);
                transform.Translate(Vector3.forward * moveDist);
            if (accelerate > 0)
            {
                wheel_right.transform.Rotate(0, 0, -10*animal_speed * Time.deltaTime);
                wheel_left.transform.Rotate(0, 0, 10*(animal_speed) * (Time.deltaTime));
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
                GetComponentInParent<Player_Controller>().Heal();
                Destroy(other.gameObject);
            }
            
        }
    }





}
    
