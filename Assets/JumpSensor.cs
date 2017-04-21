using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSensor : MonoBehaviour {

	private int touchCount = 0;

	private void OnTriggerEnter(Collider other){
		touchCount ++;	
	}

	private void OnTriggerExit(Collider other){
		touchCount --;
	}

	public bool IsCanJump(){
		return touchCount > 0;
	}
}
