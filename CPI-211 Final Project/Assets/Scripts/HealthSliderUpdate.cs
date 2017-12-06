using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSliderUpdate : MonoBehaviour
{
    public Slider _slider;
	// Use this for initialization
	void Start ()
    {
		if (this.transform.parent.parent.gameObject.active)
            this.transform.parent.parent.parent.parent.parent.GetComponentInParent<Player_Controller>().determineHealthSlider(_slider);
	}
}
