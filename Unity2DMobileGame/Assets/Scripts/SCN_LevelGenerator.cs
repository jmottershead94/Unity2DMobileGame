using UnityEngine;
using System.Collections;

public class SCN_LevelGenerator : MonoBehaviour {

	[SerializeField] private GameObject pipe1;
	[SerializeField] private GameObject pipe2;
	[SerializeField] private GameObject pipe3;
	[Range(1, 5)][SerializeField] private int size = 1;

	private const float width = 2.0f;
	// Use this for initialization
	void Start () {
		for (int i = -size; i < size + 1; i++) 
		{
			for (int j = -size; j < size + 1; j++) 
			{
				GameObject object1 = (GameObject)Instantiate (pipe1, new Vector3((i * width), (j * width), 0.0f), transform.rotation);
				object1.transform.SetParent (transform);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
