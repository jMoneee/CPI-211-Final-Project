﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    //this script has a lot of inactive components that may need to be activated later
    //right now it just gives the player the ability to turn the camera on its y axis
    // Use this for initialization
    public GameObject target;
    private float cameraRotateSpeed = 4.5f;
    private float cameraStartAngle;
    private float cameraHorizAngleChange;
    private float cameraVertAngleChange;
    private Vector3 forwards;

    public string player;
    //Vector3 offset;

    void Start()
    {
        target = this.transform.parent.gameObject;

        if (this.transform.parent.parent.parent.parent.name == "Player 1") { player = "P1K"; }
        if (this.transform.parent.parent.parent.parent.name == "Player 2") { player = "P2"; }
        if (this.transform.parent.parent.parent.parent.name == "Player 3") { player = "P3"; }
        if (this.transform.parent.parent.parent.parent.name == "Player 4") { player = "P4"; }

        //offset = target.transform.position - transform.position;
        cameraStartAngle = 0;
        cameraHorizAngleChange = 0;
        cameraVertAngleChange = 0;

    }

    // Update is called once per frame
    void Update()
    {
        float cameraHorizTurn = Input.GetAxis("" + player + "_Mouse X") * cameraRotateSpeed;
        float cameraVertTurn = Input.GetAxis("" + player + "_Mouse Y") * cameraRotateSpeed;
        //target.transform.Rotate(0, cameraTurn, 0); //activate for mouse turn to also control character
        forwards = Vector3.forward;
        //float desiredAngle = target.transform.eulerAngles.y;
        //Quaternion rotation = Quaternion.Euler(15, desiredAngle, 0);


        cameraHorizAngleChange += cameraHorizTurn;
        // float cameraHorizChangeFromOrigin = cameraStartAngle + cameraHorizAngleChange;
        //if (cameraHorizChangeFromOrigin < 30f && cameraHorizChangeFromOrigin > -30f )
        //{

        transform.Rotate(0, cameraHorizTurn, 0);
        //}
        cameraVertAngleChange += cameraVertTurn;
        //if ( cameraVertAngleChange < 10f && cameraVertAngleChange > -10f)
        //{

        //   transform.Rotate(cameraVertTurn, 0, 0);

        //}
    }
    private void LateUpdate()
    {
        if (transform.forward != target.transform.forward)
        {
            Vector3 newAngle = Vector3.RotateTowards(transform.forward, target.transform.forward, 0.5f * Time.deltaTime, 0.0f);
            transform.rotation = Quaternion.LookRotation(newAngle);
        }
    }
}
