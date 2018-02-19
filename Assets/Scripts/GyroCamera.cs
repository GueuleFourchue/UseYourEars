using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroCamera : MonoBehaviour
{
	public GameObject player;

	void Start()
	{
		this.transform.parent = player.transform;
		Input.gyro.enabled = true;
	}

	void Update()
	{
		player.transform.Rotate (-Input.gyro.rotationRateUnbiased.x, 0, 0);
		this.transform.Rotate (0, -Input.gyro.rotationRateUnbiased.y, 0);
	}

}