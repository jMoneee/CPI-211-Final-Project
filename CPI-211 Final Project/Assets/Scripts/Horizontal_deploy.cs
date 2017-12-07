using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal_deploy : MonoBehaviour {

	// Use this for initialization
	void Start () {
       // Quaternion horizontal= new Quaternion(-90, 0, 0, 0);
        transform.rotation = (Quaternion.Euler(-90f, 0f, 0f));
       // transform.localScale += new Vector3(-0.75f,-0.75f, -0.75f);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
