using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class RacketController : MonoBehaviour {
	public Vector3 velocity;
	public float sensitivity;

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
		var delta = Input.GetAxis ("Mouse Y");
		this.currentPosition.y += delta * this.sensitivity;

		this.SetPosition (this.currentPosition);
		//this.SetRotatation (this.currentRotation);
	}

	void SetPosition (Vector3 pos) {
		Vector3 delta = pos - this.transform.position;
		this.rigidbody.AddForce (delta * 1000);
	}

	void SetRotatation (Quaternion rot) {
		this.transform.rotation = this.currentRotation;
	}
}
