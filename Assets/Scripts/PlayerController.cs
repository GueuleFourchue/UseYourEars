using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Camera cam;

	[Header("Walk")]
	public float walkForwardSpeed;
	public float walkBackSpeed;

	[Header("Animator")]
	public Animator animator;

	[Header("Sounds")]
	public AudioSource audioSource;
	public AudioClip footSteps;


	float screenWidth;
	float screenHeight;

	bool isWalking;

	void Start()
	{
		screenWidth = Screen.width;
		screenHeight = Screen.height;

		transform.eulerAngles = Vector3.zero;
	}

    private void Update()
    {
		if (Input.GetMouseButton(0) && Input.touchCount == 1) 
		{
			TapMovement (Input.mousePosition.x);
		}
		else if (Input.GetMouseButtonUp(0) && Input.touchCount == 1) 
		{
			if (isWalking) 
			{
				isWalking = false;
				PlayAnim ("IdleTrigger");
				Sound (footSteps, false);
			}
		}
		if (Input.touchCount > 1) 
		{
			cam.GetComponent<GyroCamera> ().ResetOrientation ();
		}
    }
		
	void TapMovement (float tapXPosition)
	{
		if (!isWalking) 
		{
			isWalking = true;
			PlayAnim ("WalkTrigger");
			Sound (footSteps, true);
		}

		if (tapXPosition > screenWidth / 2) 
		{
			transform.position += transform.forward * Time.deltaTime * walkForwardSpeed;
		}
		else
		{
			transform.position -= transform.forward * Time.deltaTime * walkBackSpeed;
		}

	}

	void PlayAnim(string trigger)
	{
		animator.SetTrigger (trigger);
	}

	void Sound(AudioClip clip, bool play)
	{
		if (play) 
		{
			audioSource.clip = clip;
			audioSource.Play ();
		}
		if (!play)
			audioSource.Stop ();
	}
}
