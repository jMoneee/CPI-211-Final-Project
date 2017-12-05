using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapHandler : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        this.transform.SetPositionAndRotation(new Vector3(this.transform.parent.position.x, this.transform.parent.position.y + 100, this.transform.parent.position.z), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.SetPositionAndRotation(new Vector3(this.transform.parent.position.x, this.transform.parent.position.y + 100, this.transform.parent.position.z), Quaternion.identity);
    }
}
