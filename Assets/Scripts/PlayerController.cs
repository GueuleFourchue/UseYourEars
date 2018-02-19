using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Camera cam;

	[Header("Walk")]
	public float walkForwardSpeed;
	public float walkBackSpeed;

    float yaw;
    float pitch;

	float screenWidth;
	float screenHeight;

	void Start()
	{
		screenWidth = Screen.width;
		screenHeight = Screen.height;
	}

    private void Update()
    {
		if (Input.GetMouseButton(0)) 
		{
			TapMovement (Input.mousePosition.x);
		}
    }
		
	void TapMovement (float tapXPosition)
	{
		if (tapXPosition > screenWidth / 2) 
		{
			transform.Translate (transform.forward * Time.deltaTime * walkForwardSpeed);
		}
		else
		{
			transform.Translate (-transform.forward * Time.deltaTime * walkBackSpeed);
		}
	}
}
