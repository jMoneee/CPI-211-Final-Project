using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_colosseum : MonoBehaviour
{
    private static int currentPlayers;
    public static GameObject[] startingListOfPlayers;
    public GameObject[] listOfPlayers;

	// Use this for initialization
	void Start ()
    {
        startingListOfPlayers = GameObject.FindGameObjectsWithTag("Player");
        listOfPlayers = startingListOfPlayers;
        setCurrentPlayers(listOfPlayers.Length);
    }
	
	// Update is called once per frame
	void Update ()
    {
        listOfPlayers = GameObject.FindGameObjectsWithTag("Player");
        currentPlayers = listOfPlayers.Length;

		if (currentPlayers == 1)
        {
            SceneManager.LoadScene("End Screen");
        }
	}

    public static int getCurrentPlayers() { return currentPlayers; }
    public static void setCurrentPlayers(int players) { currentPlayers = players; }
    public static GameObject[] getPlayerFromList() { return startingListOfPlayers; }
}
