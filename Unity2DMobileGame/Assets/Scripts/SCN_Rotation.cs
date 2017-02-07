using UnityEngine;
using System.Collections;

public class SCN_Rotation : MonoBehaviour {

	[SerializeField] private const float rotationSpeed = 1.0f;
	private float direction = 0.0f;
	private bool isRotating = false;
	float stopValue = 0.0f;
	float angleIncrement = 0.0f;
	float increment = 0.0f;
	Quaternion rotation;
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
			}
		}
	}

	public void Rotate(float dir)
	{
		//transform.Rotate(new Vector3(0.0f, 0.0f, 90.0f));

		if(!isRotating && !SCR_GameVariables.IsLocked)
		{
			isRotating = true;
			direction = dir;
			stopValue = transform.eulerAngles.z + (90.0f * dir);
			increment += direction;
			angleIncrement = 0.0f;
		}
	}
}
