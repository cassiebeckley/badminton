using UnityEngine;
using System.Collections;

public class KeepAwake : MonoBehaviour {
	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		this.rigidbody.sleepThreshold = -1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
