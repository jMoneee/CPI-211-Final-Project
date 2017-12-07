using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupSprites : MonoBehaviour
{
    public Sprite[] spriteList;
    public int currentSprite;
    public Image pickupImage;

   void Start ()
   {
        currentSprite = 0;
        pickupImage = this.GetComponent<Image>();
   }

    void LateUpdate()
    {
        currentSprite = this.transform.parent.parent.parent.parent.parent.GetComponent<AnimalController>().getPickup();
        pickupImage.sprite = spriteList[currentSprite];
    }
}
