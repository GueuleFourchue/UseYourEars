using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDebug : MonoBehaviour {

	[Header("Walk")]
	public float walkForwardSpeed;
	public float walkBackSpeed;

	public float speedH = 2.0f;
	public float speedV = 2.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;

	void Start () 
	{
		
	}
	

	void Update () 
	{
		if (Input.GetKey(KeyCode.Z)) 
		{
			//transform.Translate (transform.forward * Time.deltaTime * walkForwardSpeed);
			transform.position += transform.forward * Time.deltaTime * walkForwardSpeed;
		}
		else if (Input.GetKey(KeyCode.S))
		{
			//transform.Translate (-transform.forward * Time.deltaTime * walkBackSpeed);
			transform.position -= transform.forward * Time.deltaTime * walkBackSpeed;
		}
	}
}
