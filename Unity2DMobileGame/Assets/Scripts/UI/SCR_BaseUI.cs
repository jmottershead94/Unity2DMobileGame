using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SCR_BaseUI : MonoBehaviour 
{
	// Attributes.
	private const string scenePrefix = "SCN_";					// This is a prefix for the unity scenes in this project.
	private const string testScene = scenePrefix + "Test";		// This is the scene name for the test scene.
	private const string menuScene = scenePrefix + "MainMenu";	// This is the scene name for the main menu scene.

	// Methods.
	private void ResetGameVariables()
	{
		// If we are pausing the game on death for example, we should reset the time scale before we reload the level.
		//Time.timeScale = 1.0f;

		// The player has not started the level yet because we are resetting.
		SCR_GameVariables.IsLocked = false;
	}

	public void LoadLevel(int levelId)
	{
		// This will reset the game variables from the static game variables class.
		ResetGameVariables();

		// Load in the test scene.
		SceneManager.LoadScene(levelId);
	}

	public void LoadMenu()
	{
		// This will reset the game variables from the static game variables class.
		ResetGameVariables();

		// Load in the test scene.
		SceneManager.LoadScene(testScene);
	}

	public void Quit()
	{
		// This will reset the game variables from the static game variables class.
		ResetGameVariables();

		// Leave the application.
		Application.Quit();
	}

	public void BringOnScreen()
	{
		// Bring the UI element onto the screen.
		transform.position = SCR_GameVariables.ON_SCREEN;
	}

	public void TakeOffScreen()
	{
		// Take the UI element off screen.
		transform.position = SCR_GameVariables.OFF_SCREEN;
	}

}