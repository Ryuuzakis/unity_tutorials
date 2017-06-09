using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speedX;

	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody> (); 
	}

	void FixedUpdate() {
		// called before any physics calculation

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speedX);
	}

}
