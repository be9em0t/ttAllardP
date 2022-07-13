using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootInputScript : MonoBehaviour
{

	[System.NonSerialized] public float mouseX;
	[System.NonSerialized] public float mouseY;
	[System.NonSerialized] public float elevation;
	bool activateMouse = false;

	[SerializeField] private float MouseSensitivityX = 166f;
	[SerializeField] private float MouseSensitivityY = 66f;
	[SerializeField] private float ElevatorSpeed = 10f;

	private string messageTxt;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (activateMouse == false){
			if (Input.GetMouseButtonDown(0)){
				mouseX = Input.GetAxis("Mouse X") * MouseSensitivityX * Time.deltaTime;
				mouseY = Input.GetAxis("Mouse Y") * MouseSensitivityY * Time.deltaTime;
				activateMouse = true;
			}
			messageTxt = "Click screen to activate";
		}
		else {
			messageTxt = "";
			mouseX = Input.GetAxis("Mouse X") * MouseSensitivityX * Time.deltaTime;
			mouseY = Input.GetAxis("Mouse Y") * MouseSensitivityY * Time.deltaTime;
			elevation = Input.GetAxis("Elevator") * ElevatorSpeed * Time.deltaTime;
			if (Input.GetKeyDown(KeyCode.Escape))
				{
						Application.Quit();
				}
		}

	}

	void OnGUI()
	{
	GUI.Box(new Rect(10, 10, 200, 30), messageTxt);
	}
}

