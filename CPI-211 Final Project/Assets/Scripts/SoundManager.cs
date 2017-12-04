using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour {

    public static AudioClip menu_sound1, menu_sound2;
    static AudioSource soundPlayer;
    GameObject[] musicPlayers;

	// Use this for initialization
	void Start ()
    {
        menu_sound1 = Resources.Load<AudioClip>("MENU A_Select");
        menu_sound2 = Resources.Load<AudioClip>("MENU A - Back");

        soundPlayer = GetComponent<AudioSource>();
    }

    void Awake()
    {
        musicPlayers = GameObject.FindGameObjectsWithTag("Music");
        if (musicPlayers.Length > 1) { Destroy(this.gameObject); }

        DontDestroyOnLoad(this.gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (soundPlayer.isPlaying && (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Colosseum Game") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Figure8Game")))
        { soundPlayer.Stop(); }

        if (!soundPlayer.isPlaying && (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("Colosseum Game") || SceneManager.GetActiveScene() != SceneManager.GetSceneByName("Figure8Game")))
        { soundPlayer.Play(); }
	}

    public static void PlaySound (string sound)
    {
        switch (sound)
        {
            case "menu-forward":
                {
                    soundPlayer.PlayOneShot(menu_sound1);
                    break;
                }

            case "menu-back":
                {
                    soundPlayer.PlayOneShot(menu_sound2);
                    break;
                }
        }
    }
}
