using UnityEngine;
using System.Collections;

public class SCR_GameVariables
{

	private static bool isLocked = false;		// This will mean that the player has started the game.

	// This will let us know if the player has started the game.
	public static bool IsLocked
	{
		get { return isLocked; }
		set { isLocked = value; }
	}
}
