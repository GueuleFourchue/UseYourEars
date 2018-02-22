using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchLight : MonoBehaviour {

	public Transform cam;
	public float rotateSpeed;

	void Update () 
	{
		transform.position = cam.position;

		transform.rotation = Quaternion.Lerp(transform.rotation, cam.rotation, Time.deltaTime * rotateSpeed);
	}
}
