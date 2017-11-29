using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCameraMove : MonoBehaviour
{

    public Transform mmCamera;
    public float cameraAxis;

    // Use this for initialization
    void Start ()
    {
        cameraAxis = MainMenuCameraMove.getCameraRotation();
        mmCamera.transform.Rotate(new Vector3(0, cameraAxis));
	}
	
	// Update is called once per frame
	void Update ()
    {
        MainMenuCameraMove.updateCameraRotation(0.1f);
        mmCamera.transform.Rotate(new Vector3(0, 0.1f));
    }
}
