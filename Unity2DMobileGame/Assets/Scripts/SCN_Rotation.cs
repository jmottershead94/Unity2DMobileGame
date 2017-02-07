using UnityEngine;
using System.Collections;

public class SCN_Rotation : MonoBehaviour {

	private float direction = 0.0f;
	private bool isRotating = false;
	float angleIncrement = 0.0f;
	float increment = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(isRotating)
		{
			transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, direction));
			angleIncrement++;
			if(angleIncrement == 90.0f)
			{
				isRotating = false;
				transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
				transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, (90.0f *increment)));
				for(int i = 0; i < transform.childCount; i++)
				{
					//Vector3 newPosition = new Vector3((float)Mathf.RoundToInt(transform.GetChild(i).transform.position.x), (float)Mathf.RoundToInt(transform.GetChild(i).transform.position.y), transform.GetChild(i).transform.position.z);
					//transform.GetChild(i).transform.position = newPosition;
				}
			}
		}
	}

	public void Rotate(float dir)
	{
		if(!isRotating && !SCR_GameVariables.IsLocked)
		{
			isRotating = true;
			direction = dir;
			increment += direction;
			angleIncrement = 0.0f;
		}
	}
}
