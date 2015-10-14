using UnityEngine;
using System.Collections;

public class BirdieMaker : MonoBehaviour {
	public Transform birdiePrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (SixenseInput.GetController (SixenseHands.RIGHT).GetButtonDown(SixenseButtons.BUMPER)) {
			Instantiate (birdiePrefab, this.transform.position, Quaternion.identity);
		}
	}
}
