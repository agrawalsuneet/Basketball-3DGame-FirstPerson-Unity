using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public GameObject ball;
	public GameObject playerCamera;

	public float ballDistance = 2.0f;

	// Use this for initialization
	void Start () {
		ball.GetComponent<Rigidbody> ().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		ball.transform.position = playerCamera.transform.position + (playerCamera.transform.forward * ballDistance);
	}
}
