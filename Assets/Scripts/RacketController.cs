using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class RacketController : MonoBehaviour {
	public SixenseHands hand;

	public Vector3 velocity;
	public float xSensitivity;
	public float ySensitivity;

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
		//var deltaY = Input.GetAxis ("Mouse Y");
		//this.currentPosition.y += deltaY * this.ySensitivity;

		//var deltaX = Input.GetAxis ("Mouse X");
		//this.currentPosition.x += deltaX * this.xSensitivity;
		var controller = SixenseInput.GetController (this.hand);

		// convert to meters
		this.currentPosition = controller.Position / 1000 + this.defaultPosition;
		this.currentRotation = controller.Rotation;

		if (Input.GetKeyDown (KeyCode.F)) {
			print (controller.Position);
		}

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
