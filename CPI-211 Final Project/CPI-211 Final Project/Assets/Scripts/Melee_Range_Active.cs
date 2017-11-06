using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Range_Active : MonoBehaviour {
    private bool active;
    private GameObject collision;
    
	// Use this for initialization
	void Start () {
        active = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        
         active = true;
         collision = other.GetComponent<GameObject>();

    
    }
    
    private void OnTriggerExit(Collider other)
    {
        active = false;
        collision = null;
    }
    public bool IsActive()
    {
        return active;
    }
    public GameObject GetOther()
    {
        return collision;
    }
}
