using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public BallScript ball;
	public GameObject playerCamera;

	public float ballDistance = 2.0f;
	public float ballThrowingForce = 550.0f;

	public bool holdingBall = true;

	// Use this for initialization
	void Start () {
		ball.GetComponent<Rigidbody> ().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (holdingBall) {
		ball.transform.position = playerCamera.transform.position + (playerCamera.transform.forward * ballDistance);

			if (Input.GetMouseButtonDown (0)) {
				holdingBall = false;
				ball.SetTrailActive (true);
				ball.GetComponent<Rigidbody> ().useGravity = true;
				ball.GetComponent<Rigidbody> ().AddForce (playerCamera.transform.forward * ballThrowingForce);
			}
			
		}
	}
}
