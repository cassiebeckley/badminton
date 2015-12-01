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
	
	private Quaternion lastRotation;
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

		if (controller != null && controller.Enabled) {

			// convert to meters
			this.currentPosition = controller.Position / 1000 + this.defaultPosition;
			this.currentRotation = controller.Rotation;

			this.SetPosition (this.currentPosition);
			this.SetRotatation (this.currentRotation);
		}
	}

	void SetPosition (Vector3 pos) {
		Vector3 delta = pos - this.transform.position;
		this.rigidbody.AddForce (delta * 1000);
	}

	void SetRotatation (Quaternion rot) {
		Vector3 delta = (rot * Quaternion.Inverse(this.transform.rotation)).eulerAngles;

		if ( delta.x > 180 ) delta.x -= 360;
		if ( delta.y > 180 ) delta.y -= 360;
		if ( delta.z > 180 ) delta.z -= 360;
		
		if (Input.GetKeyDown (KeyCode.F)) {
			print (delta);
		}
		this.rigidbody.AddTorque(delta * 100);
		//this.lastRotation = this.transform.rotation;
		//this.transform.rotation = rot;
	}
}
