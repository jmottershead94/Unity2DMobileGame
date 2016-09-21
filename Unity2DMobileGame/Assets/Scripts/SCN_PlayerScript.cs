using UnityEngine;
using System.Collections;

public class SCN_PlayerScript : MonoBehaviour {

	[Range(50.0f, 200.0f)][SerializeField] private float speed = 100.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Go()
	{
		GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0.0f));
	}
}
