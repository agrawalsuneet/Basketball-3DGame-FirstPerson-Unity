using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public GameObject trailObject;

	// Use this for initialization
	void Start () {
		trailObject.SetActive (false);
	}

	public void SetTrailActive (bool isActive){
		trailObject.SetActive (isActive);
	}
}
