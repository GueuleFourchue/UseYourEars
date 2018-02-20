using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroCamera : MonoBehaviour
{
	public GameObject player;
	public float rotateSpeedMultiplier;

	void Start()
	{
		Screen.orientation = ScreenOrientation.Landscape;
		if (this.transform.parent == null)
			this.transform.parent = player.transform;

		transform.eulerAngles = Vector3.zero;
		Input.gyro.enabled = true;
	}

	void Update()
	{
		this.transform.Rotate (-Input.gyro.rotationRateUnbiased.x * rotateSpeedMultiplier, 0, 0);
		player.transform.Rotate (0, -Input.gyro.rotationRateUnbiased.y * rotateSpeedMultiplier, 0);
	}

	public void ResetOrientation()
	{
		transform.rotation = new Quaternion (0, 0, 0, 0);
	}
}