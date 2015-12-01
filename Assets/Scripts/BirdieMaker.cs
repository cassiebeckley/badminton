using UnityEngine;
using System.Collections;

public class BirdieMaker : MonoBehaviour {
	public Transform birdiePrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var controller = SixenseInput.GetController (SixenseHands.RIGHT);
		if (controller != null && controller.GetButtonDown(SixenseButtons.BUMPER)) {
			Instantiate (birdiePrefab, this.transform.position, Quaternion.identity);
		}
	}
}
