using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float speed = 30;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, -Time.deltaTime * speed, 0), Space.World);
	}
}
