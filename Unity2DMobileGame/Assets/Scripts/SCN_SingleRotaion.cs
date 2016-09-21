using UnityEngine;
using System.Collections;

public class SCN_SingleRotaion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseDown()
	{
		transform.parent.transform.Rotate(0.0f, 0.0f, 90.0f);
	}
}
