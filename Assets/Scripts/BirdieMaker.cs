using UnityEngine;
using System.Collections;

public class BirdieMaker : MonoBehaviour {
	public Transform birdiePrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.S)) {
			Instantiate (birdiePrefab, this.transform.position, Quaternion.identity);
		}
	}
}
