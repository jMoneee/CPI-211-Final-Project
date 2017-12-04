using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameSoundManager : MonoBehaviour {

    public static AudioClip swing_sound, pickup_sound;
    static AudioSource soundPlayer;

    // Use this for initialization
    void Start()
    {
        swing_sound = Resources.Load<AudioClip>("swing-sound");
        pickup_sound = Resources.Load<AudioClip>("pickup_sound");

        soundPlayer = GetComponent<AudioSource>();
    }

    public static void PlaySound(string sound)
    {
        switch (sound)
        {
            case "swing":
                {
                    soundPlayer.PlayOneShot(swing_sound);
                    break;
                }

            case "pickup":
                {
                    soundPlayer.PlayOneShot(pickup_sound);
                    break;
                }
        }
    }
}
