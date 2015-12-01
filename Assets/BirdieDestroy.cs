using UnityEngine;
using System.Collections;

public class BirdieDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (SixenseInput.GetController (SixenseHands.LEFT).GetButtonDown (SixenseButtons.BUMPER)) {
			Destroy (this.gameObject);
		}
	}
}
