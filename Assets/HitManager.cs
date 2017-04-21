using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitManager : MonoBehaviour {

	public PlayerController pc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnParticleCollision(GameObject coll){
		Debug.Log ("IKU");
		if (coll.gameObject.tag == "DM")
			pc.Hit (20);
	}
}
