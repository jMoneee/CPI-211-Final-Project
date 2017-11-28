using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour {

    //this script has a lot of inactive components that may need to be activated later
    //right now it just gives the player the ability to turn the camera on its y axis
    // Use this for initialization
    public GameObject target;
    private float cameraRotateSpeed = 4.5f;
    private float cameraStartAngle;
    private float cameraHorizAngleChange;
    private float cameraVertAngleChange;

    public string player = "P1";
    //Vector3 offset;
    
	void Start () {
        //offset = target.transform.position - transform.position;
        cameraStartAngle = 0;
        cameraHorizAngleChange = 0;
        cameraVertAngleChange = 0;
        
	}

    // Update is called once per frame
    void LateUpdate() {
        float cameraHorizTurn = Input.GetAxis(""+player+"_Mouse X") * cameraRotateSpeed;
        float cameraVertTurn = Input.GetAxis("" + player + "_Mouse Y") * cameraRotateSpeed;
        //target.transform.Rotate(0, cameraTurn, 0); //activate for mouse turn to also control character

        //float desiredAngle = target.transform.eulerAngles.y;
        //Quaternion rotation = Quaternion.Euler(15, desiredAngle, 0);

        
        
        if (cameraHorizAngleChange < 30f && cameraHorizAngleChange > -30f )
        {
            cameraHorizAngleChange += cameraHorizTurn;
            transform.Rotate(0, cameraHorizTurn, 0);
        }
        if ( cameraVertAngleChange < 10f && cameraVertAngleChange > -10f)
        {
            transform.Rotate(cameraVertTurn, 0, 0);
            cameraVertAngleChange += cameraVertTurn;
        }
    }
}
