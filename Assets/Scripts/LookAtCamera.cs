using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {

	GameObject target;

	// Use this for initialization
	void Start () {
        
		target = GameObject.Find ("AR Camera");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPosition = new Vector3 (target.transform.position.x, transform.position.y, target.transform.position.z);
		transform.LookAt (targetPosition);
	}
}
