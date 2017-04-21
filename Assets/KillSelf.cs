using UnityEngine;
using System.Collections;

public class KillSelf : MonoBehaviour {

	float aliveTime = 1f;

	// Use this for initialization
	void Start () {
		Invoke ("DestroySelf",aliveTime);
	}

	// Update is called once per frame
	public void DestroySelf()
	{
		GameObject.Destroy (this.gameObject);
	}
}