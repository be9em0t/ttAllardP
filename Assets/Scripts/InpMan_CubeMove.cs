using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InpMan_CubeMove : MonoBehaviour
{

	[SerializeField] private float speed;

	// Update is called once per frame
	void Update()
	{
		Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		movement.Normalize();
		movement *= speed * Time.deltaTime;

		transform.Translate( 0f, movement.y, 0f);
	}
}
