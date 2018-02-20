using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroCamera2 : MonoBehaviour
{
	public GameObject player;

	//
	Quaternion rot;

	void Start()
	{
		Screen.orientation = ScreenOrientation.Landscape;
		if (this.transform.parent == null)
			this.transform.parent = player.transform;

		transform.eulerAngles = Vector3.zero;
		Input.gyro.enabled = true;

		//
		rot = new Quaternion(0,0,1,0);
	}

	void Update()
	{
		transform.localRotation = new Quaternion(Input.gyro.attitude.x, 0, 0, 0);
		player.transform.localRotation = new Quaternion(0, Input.gyro.attitude.x, 0, 0);
	}

	public void ResetOrientation()
	{
		transform.eulerAngles = Vector3.zero;
		player.transform.eulerAngles = Vector3.zero;
	}
}