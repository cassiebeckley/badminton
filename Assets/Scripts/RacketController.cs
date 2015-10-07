using UnityEngine;
using System.Collections;

public class RacketController : MonoBehaviour {
	public Vector3 velocity;
	public float maxPosition;

	private Vector3 defaultPosition;

	// Use this for initialization
	void Start () {
		this.defaultPosition = this.transform.position;
	}
	
	// use FixedUpdate for rigidbody
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Space)) {
			if (this.transform.position.y < this.maxPosition) {
				this.transform.position += this.velocity * Time.deltaTime;
			}
		} else {
			this.transform.position = this.defaultPosition;
		}
	}
}
