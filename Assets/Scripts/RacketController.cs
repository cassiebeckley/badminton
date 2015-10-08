using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class RacketController : MonoBehaviour {
	public Vector3 velocity;
	public float maxPosition;

	private Vector3 defaultPosition;
	private Vector3 currentPosition;

	private Quaternion currentRotation;

	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		this.defaultPosition = this.currentPosition = this.transform.position;
		this.currentRotation = this.transform.rotation;
		this.rigidbody = this.GetComponent<Rigidbody> ();
	}
	
	// use FixedUpdate for rigidbody
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Space)) {
			this.currentPosition = this.currentPosition + this.velocity * Time.deltaTime;
		} else {
			this.currentPosition = this.defaultPosition;
		}

		this.SetPosition (this.currentPosition);
		//this.SetRotatation (this.currentRotation);
	}

	void SetPosition (Vector3 pos) {
		Vector3 delta = pos - this.transform.position;
		this.rigidbody.AddForce (delta * 100);
	}

	void SetRotatation (Quaternion rot) {
		this.transform.rotation = this.currentRotation;
	}
}
