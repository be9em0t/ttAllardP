using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootInputScript : MonoBehaviour
{


	[System.NonSerialized] public float mouseX;
	[System.NonSerialized] public float mouseY;
	[System.NonSerialized] public float elevation;
	public float elevationMin = 3f;
	public float elevationMax = 20f;
	// [System.NonSerialized] public bool waveTrigger = false;
	bool activateMouse = false;

	[SerializeField] private float MouseSensitivityX = 166f;
	[SerializeField] private float MouseSensitivityY = 66f;
	[SerializeField] private float ElevatorSpeed = 10f;

	private bool showMessage = true;
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
			messageTxt = "Arrow Up/Down - Elevator\nH - toggle this message\nG - Ground wave\nR - Road wave\nB - Building wave";
			mouseX = Input.GetAxis("Mouse X") * MouseSensitivityX * Time.deltaTime;
			mouseY = Input.GetAxis("Mouse Y") * MouseSensitivityY * Time.deltaTime;
			elevation = Input.GetAxis("Elevator") * ElevatorSpeed * Time.deltaTime;
			if (Input.GetKeyDown(KeyCode.Escape))
				{
						Application.Quit();
				}
			if (Input.GetKeyDown(KeyCode.H))
				{
					if (showMessage != true){
						showMessage = true;
					}
					else showMessage = false;
				}
			// if (Input.GetKeyDown(KeyCode.G))
			// 	{
			// 		waveTrigger=true;
			// 	}
		}

	}

	
	void OnGUI()
	{
		if (showMessage == true){
			GUI.Box(new Rect(10, 10, 200, 100), messageTxt, "label");
		}
	}


}

