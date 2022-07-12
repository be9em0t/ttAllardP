using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InpMan_CameraControl : MonoBehaviour
{
	float mouseX;
	float mouseY;
	float yaw = 0f;
	float pitch = 0f;
	bool setMouse = false;

	[SerializeField] private float MouseSensitivityX = 166f;
	[SerializeField] private float MouseSensitivityY = 66f;

	[SerializeField] private float ElevatorSpeed = 10f;

	// Update is called once per frame
	void Update()
	{
		if (setMouse == false){
			if (Input.GetMouseButtonDown(0)){
				mouseX = Input.GetAxis("Mouse X") * MouseSensitivityX * Time.deltaTime;
				mouseY = Input.GetAxis("Mouse Y") * MouseSensitivityY * Time.deltaTime;
				setMouse = true;
			}
		}
		else {
		mouseX = Input.GetAxis("Mouse X") * MouseSensitivityX * Time.deltaTime;
		mouseY = Input.GetAxis("Mouse Y") * MouseSensitivityY * Time.deltaTime;
		yaw += mouseX;
		pitch -= mouseY;
		transform.eulerAngles = new Vector3(pitch, yaw, 0f);

		float elevation = Input.GetAxis("Vertical");
		elevation *= ElevatorSpeed * Time.deltaTime;
		transform.Translate(0f, elevation, 0f);
		}

	}
}
