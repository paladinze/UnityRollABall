using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	Vector3 CameraToPlayerVector;
	public Player player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<Player> ();
		CameraToPlayerVector = gameObject.transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		gameObject.transform.position = player.transform.position + CameraToPlayerVector;
	}
}
