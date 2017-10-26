using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody rb;
	public int speed = 5;

	void Start() {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate() {
		float forceX = Input.GetAxis ("Horizontal");
		float forceZ = Input.GetAxis ("Vertical");
		Vector3 force = new Vector3 (forceX, 0, forceZ);
		force *= speed;
		ForceMode fmode = ForceMode.Force;

		rb.AddForce (force, fmode);
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("pickup")) {
			Destroy(other.gameObject);
		}

	}

}
