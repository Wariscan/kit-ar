using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour 
{
	public float rotSpeed = 20;

	void OnMouseDrag()
	{
		float rotX = Input.GetAxis("Mouse X")*rotSpeed * Time.deltaTime;

		transform.Rotate(Vector3.up, -rotX);
	}
}
