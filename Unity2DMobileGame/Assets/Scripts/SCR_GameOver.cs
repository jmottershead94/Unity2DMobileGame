using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

// Game over IS A base UI, therefore inherits from it.
// This will handle any navigation from the game over panel.
public class SCR_GameOver : SCR_BaseUI
{
	// Attributes.
	private SCN_PlayerScript player;

	// Methods.
	// Use this for initialization
	void Start () 
	{
		// Initialising our attributes.
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<SCN_PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
