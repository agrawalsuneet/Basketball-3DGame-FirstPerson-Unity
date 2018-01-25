using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour {

	public PlayerScript player;
	public float resetTime = 5.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (!player.holdingBall) {
			resetTime -= Time.deltaTime;

			if (resetTime <= 0) {
				SceneManager.LoadScene ("BasketballGameScene");
			}
		}
	}
}
