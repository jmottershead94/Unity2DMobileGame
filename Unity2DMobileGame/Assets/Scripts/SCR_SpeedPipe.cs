using UnityEngine;
using System.Collections;

public class SCR_SpeedPipe : MonoBehaviour {

	private enum PipeType
	{
		fast,
		normal,
		slow,
		reverse
	};
	[SerializeField] PipeType type = PipeType.normal;
	[SerializeField] [Range(0.0f, 4.0f)] float speedModifier = 1.0f;
	private float velocity = 0.0f;

	// Use this for initialization
	void Start () {

		switch(type)
		{
			case PipeType.fast:
			{
				velocity = 1.5f;

				break;
			}
			case PipeType.normal:
			{
				velocity = 1.0f;

				break;
			}
			case PipeType.slow:
			{
				velocity = 0.5f;

				break;
			}
			case PipeType.reverse:
			{
				velocity = -1.0f;

				break;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.tag == "Player" && type != PipeType.normal)
		{
			collider.attachedRigidbody.velocity *= (velocity * speedModifier);	

			Debug.Log("Velocity = " + collider.attachedRigidbody.velocity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
