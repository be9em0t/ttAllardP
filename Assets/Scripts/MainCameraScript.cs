using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
	public GameObject rootObj;
	public RootInputScript rootInput;

	float mouseX;
	float mouseY;
	float elevation;
	float yaw = 0f;
	float pitch = 0f;

	// Start is called before the first frame update
	void Start()
	{
		rootObj = GameObject.Find("rootObj");
		rootInput = rootObj.GetComponent<RootInputScript>();
	}

	// Update is called once per frame
	void Update()
	{
		yaw += rootInput.mouseX;
		pitch -= rootInput.mouseY;
		transform.eulerAngles = new Vector3(pitch, yaw, 0f);
		transform.Translate(0f,rootInput.elevation, 0f);

		
	}
}
