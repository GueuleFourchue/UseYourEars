using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonsMove : MonoBehaviour {
	public Camera cam;

	[Header("Walk")]
	public float walkForwardSpeed;
	public float walkBackSpeed;

	[Header("Animator")]
	public Animator animator;

	[Header("Sounds")]
	public AudioSource audioSource;
	public AudioClip footSteps;

	float volume;

	bool isWalking;
	bool isWalkingForward;

	void Start()
	{
		transform.eulerAngles = Vector3.zero;
		volume = audioSource.volume;
	}

	private void Update()
	{
		if (isWalking) 
		{
			if (isWalkingForward) 
				transform.position += transform.forward * Time.deltaTime * walkForwardSpeed;
			else 
				transform.position -= transform.forward * Time.deltaTime * walkBackSpeed;
		}

		if (Input.touchCount > 1) 
		{
			cam.GetComponent<GyroCamera> ().ResetOrientation ();
		}

	}
		

	public void Move(bool forward)
	{
		if (!isWalking) 
		{
			isWalking = true;
			PlayAnim ("WalkTrigger");
			Sound (footSteps, true);
		}
		if (forward == true)
			isWalkingForward = true;
		else
			isWalkingForward = false;
	}

	public void StopMoving()
	{
		if (isWalking) 
		{
			isWalking = false;
			PlayAnim ("IdleTrigger");
			Sound (footSteps, false);
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
			audioSource.volume = volume;
			audioSource.clip = clip;
			audioSource.Play ();
		}
		if (!play) 
		{
			audioSource.Stop ();
		}
			
	}
}