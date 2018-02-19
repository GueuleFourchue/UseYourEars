using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDebug : MonoBehaviour {

	[Header("Walk")]
	public float walkForwardSpeed;
	public float walkBackSpeed;


	void Start () {
		
	}
	

	void Update () 
	{
		if (Input.GetKey(KeyCode.Z)) 
		{
			transform.Translate (transform.forward * Time.deltaTime * walkForwardSpeed);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			transform.Translate (-transform.forward * Time.deltaTime * walkBackSpeed);
		}
	}
}
