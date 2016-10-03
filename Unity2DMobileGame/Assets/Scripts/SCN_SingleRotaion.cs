using UnityEngine;
using System.Collections;

public class SCN_SingleRotaion : MonoBehaviour {


	bool swapping = false;		// If this pipe is going to swap with another pipe.
	bool over = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseDown()
	{
		//Debug.Log("Tap detected.");

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
		//over = true;
		if(Input.GetMouseButtonUp(0) && SCR_GameVariables.isPressed)
		{

			if((transform.position.x * -1) == SCR_GameVariables.swappingObject.position.x || (transform.position.y * -1) == SCR_GameVariables.swappingObject.position.y)
			{
				Vector3 vec = transform.parent.position;
				Debug.Log(vec);
				transform.parent.position = SCR_GameVariables.swappingObject.parent.position;
				SCR_GameVariables.swappingObject.parent.position = vec;
				Debug.Log(vec);
			}
		}
	}

	void OnMouseExit()
	{
		//over = false;
	}

	void OnMouseUp()
	{
		Debug.Log(over);
		if(SCR_GameVariables.isPressed && over)
		{
			Debug.Log("BOOM");
			transform.position = SCR_GameVariables.swappingObject.position;
			transform.rotation = SCR_GameVariables.swappingObject.rotation;
			Debug.Log(transform.position.x);
			Debug.Log(SCR_GameVariables.swappingObject.position.x);
		}
	}

	// 
	void OnMouseUpAsButton()
	{
		//Debug.Log("BOOM");
		if(swapping)
		{
			transform.parent.Rotate(0.0f, 0.0f, 90.0f);
			swapping = false;
			SCR_GameVariables.isPressed = false;
		}
	}

}
