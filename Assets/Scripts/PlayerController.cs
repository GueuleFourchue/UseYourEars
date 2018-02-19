using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [Header("Mouse")]
    public float hDeadZone;
    public float vDeadZone;
    public float hSpeed;
    public float vSpeed;
    public Camera cam;

    float yaw;
    float pitch;

    private void Update()
    {
		/*
        if (Input.GetAxis("Mouse X") != 0)
        {
            yaw = hSpeed * Input.GetAxis("Mouse X");
            CamRotation();
        }
        if (Input.GetAxis("Mouse Y") != 0)
        {
            pitch = vSpeed * Input.GetAxis("Mouse Y");
            CamRotation();
        }
        */

		cam.transform.Rotate (-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, 0);
    }

    void CamRotation()
    {
        cam.transform.Rotate(new Vector3(pitch, yaw, 0.0f));
    }
   
}
