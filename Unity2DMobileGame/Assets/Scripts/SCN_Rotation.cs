using UnityEngine;
using System.Collections;

public class SCN_Rotation : MonoBehaviour {

	[SerializeField] private const float rotationSpeed = 5.0f;
	private float direction = 0.0f;
	private float rotationValue = 0.0f;
	private bool isRotating = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(isRotating)
		{
			transform.Rotate(new Vector3(0.0f, 0.0f, rotationSpeed * direction));
			rotationValue += rotationSpeed;
			if(rotationValue >= 90.0f)
			{
				isRotating = false;
				rotationValue = 0.0f;
			}
		}
	}

	public void Rotate(float dir)
	{
		if(!isRotating && !SCR_GameVariables.IsLocked)
		{
			isRotating = true;
			direction = dir;
		}
	}
}
