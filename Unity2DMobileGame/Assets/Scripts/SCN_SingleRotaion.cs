using UnityEngine;
using System.Collections;

public class SCN_SingleRotaion : MonoBehaviour {


	bool swapping = false;		// If this pipe is going to swap with another pipe.
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseDown()
	{
		if(!SCR_GameVariables.IsLocked)
		{
			//transform.parent.Rotate(0.0f, 0.0f, 90.0f);
			swapping = true;
			SCR_GameVariables.isPressed = true;
			SCR_GameVariables.swappingObject = transform;
		}
	}

	void OnMouseOver()
	{
		if(Input.GetMouseButtonUp(0) && SCR_GameVariables.isPressed)
		{
			if((transform.position.x * -1) == SCR_GameVariables.swappingObject.position.x || (transform.position.y * -1) == SCR_GameVariables.swappingObject.position.y)
			{
				if((transform.position.x * -1) != SCR_GameVariables.swappingObject.position.x || (transform.position.y * -1) != SCR_GameVariables.swappingObject.position.y)
				{
					Vector3 vec = transform.parent.position;
					Debug.Log(vec);
					transform.parent.position = SCR_GameVariables.swappingObject.parent.position;
					SCR_GameVariables.swappingObject.parent.position = vec;
					Debug.Log(vec);
				}
			}
		}
	}

	void OnMouseUpAsButton()
	{
		if(swapping)
		{
			transform.parent.Rotate(0.0f, 0.0f, 90.0f);
			swapping = false;
			SCR_GameVariables.isPressed = false;
		}
	}

}
