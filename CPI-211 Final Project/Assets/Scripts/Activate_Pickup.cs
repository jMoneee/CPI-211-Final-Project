using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Pickup : MonoBehaviour {

    public float timer;
    // Use this for initialization
    void Start()
    {
        this.transform.Rotate(new Vector3(90, 0));
        timer = 5f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (timer > 0)
            timer -= Time.deltaTime;
        else if (timer <= 0)
            setTag();
	}

    void setTag()
    {
        if (this.gameObject.name == "caltrops_deployed(Clone)")
            this.gameObject.tag = "Caltrops_Deployed";
        else if (this.gameObject.name == "net_deployed(Clone)")
            this.gameObject.tag = "Net_Deployed";
    }
}
