using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovementGame : MonoBehaviour {
	private Rigidbody rb;
	private Vector3 normalizedVelocity;
	public float maxSpeed;
	public float movePower = 10;
	public float jumpPower = 100;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		// Move forward and backward
		if (Input.GetKey (KeyCode.W)) {
			rb.AddForce (transform.forward * movePower);
		} else if (Input.GetKey (KeyCode.S)) {
			rb.AddForce (-transform.forward * movePower);
		}
		// Move left and right
		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (-transform.right * movePower);
		} else if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (transform.right * movePower);
		}
		// Jump
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (transform.up * jumpPower);
		}

		// Limit horizontal speed
		if (rb.velocity.magnitude > maxSpeed) {
			normalizedVelocity = rb.velocity.normalized * maxSpeed;
			normalizedVelocity.y = rb.velocity.y;
			rb.velocity = normalizedVelocity;
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Node") {
			maxSpeed += 2;
		}
	}
	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "Node") {
			maxSpeed -= 2;
		}
	}
}
