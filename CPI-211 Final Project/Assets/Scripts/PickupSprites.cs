using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSprites : MonoBehaviour
{
    public GameObject[] spriteList;
    public int currentSprite;
	// Use this for initialization
	void Start ()
    {
		for (int i = 0; i < spriteList.Length; i++)
        { spriteList[i].gameObject.SetActive(false); }
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentSprite = this.transform.parent.parent.parent.GetComponentInParent<AnimalController>().getPickup();

        if (currentSprite != 0)
        { spriteList[currentSprite+1].gameObject.SetActive(true); }

        else
        {
            for (int i = 0; i < spriteList.Length; i++)
            { spriteList[i].gameObject.SetActive(false); }
        }
	}
}
