using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip snd_damage, snd_swing;
    static AudioSource soundPlayer;

	// Use this for initialization
	void Start ()
    {
        snd_damage = Resources.Load<AudioClip>("damage");
        snd_swing = Resources.Load<AudioClip>("weapon_swing");

        soundPlayer = GetComponent<AudioSource>();

        DontDestroyOnLoad(this.gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public static void PlaySound (string sound)
    {
        switch (sound)
        {
            case "swing":
                {
                    soundPlayer.PlayOneShot(snd_swing);
                    break;
                }

            case "damage":
                {
                    soundPlayer.PlayOneShot(snd_damage);
                    break;
                }
        }
    }
}
