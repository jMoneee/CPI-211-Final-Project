using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    public GameObject animalToFollow;
    private Vector3 offset;
	// Use this for initialization
	void Start ()
    {
        offset = transform.position - animalToFollow.transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void LateUpdate()
    {
        transform.position = animalToFollow.transform.position + offset;
    }
}
