using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public int speed = 5;
	public Text scoreText;
	public Text winText;

	private int hitCount = 0;
	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		SetScoreText ();
		winText.text = "";
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
			hitCount++;
			SetScoreText ();
			if (hitCount == 8) {
				SetWinText ();
			}
		}

	}

	void SetScoreText() {
		scoreText.text = "Score: " + hitCount.ToString ();
	}

	void SetWinText() {
		winText.text = "You Win!";
	}

}
