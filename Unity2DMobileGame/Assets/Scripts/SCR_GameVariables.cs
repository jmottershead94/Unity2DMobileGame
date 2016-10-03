using UnityEngine;
using System.Collections;

public class SCR_GameVariables
{
	// Attributes.
	public static Vector2 ON_SCREEN = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
	public static Vector2 OFF_SCREEN = new Vector2(Screen.width * 0.5f, Screen.height * 2.0f);
	public static bool isPressed = false;
	public static Transform swappingObject;

	private static bool isLocked = false;			// This will mean that the player has started the game.

	// Methods.
	// Getters/Setters.
	// This will let us know if the player has started the game.
	public static bool IsLocked
	{
		get { return isLocked; }
		set { isLocked = value; }
	}
}
