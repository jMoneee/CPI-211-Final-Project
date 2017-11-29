using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCameraMove : MonoBehaviour {

    public Transform mmCamera;
    static float cameraRotationAxis;

    void Start()
    {
        cameraRotationAxis = mmCamera.rotation.y;
    }

    // Update is called once per frame
    void Update()
    {
        mmCamera.transform.Rotate(new Vector3(0, 0.1f));
        cameraRotationAxis = mmCamera.rotation.y;
    }

    public static float getCameraRotation()
    {
        return cameraRotationAxis;
    }

    public static void updateCameraRotation(float axis)
    {
        cameraRotationAxis = axis;
    }
}
