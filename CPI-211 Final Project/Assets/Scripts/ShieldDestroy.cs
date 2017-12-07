using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldDestroy : MonoBehaviour
{
    float timer;
    // Use this for initialization
    void Start()
    {
        timer += 15f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
