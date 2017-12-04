using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChariotAngleAdjust : MonoBehaviour {

    // Use this for initialization
    private Vector3 intial;
    public Transform target;
	void Start () {
        intial = Vector3.forward;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newAngle = Vector3.RotateTowards(transform.forward, target.transform.forward, 0.5f * Time.deltaTime, 0.0f);
        transform.rotation = Quaternion.LookRotation(newAngle);
    }
}
