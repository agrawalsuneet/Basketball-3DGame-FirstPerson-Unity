using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAreaScript : MonoBehaviour {

	public GameObject effectObject;

	void Start (){
		effectObject.SetActive (false);
	}

	void OnTriggerEnter (Collider otherCollider){
		if(null != otherCollider.GetComponent<BallScript>()){
			effectObject.SetActive (true);
		}
	}
}
