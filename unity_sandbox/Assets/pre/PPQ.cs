using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PPQ: MonoBehaviour 
{
	public float speed = 10;

	void FixedUpdate ()
	{
		float x = CrossPlatformInputManager.GetAxis("Horizontal");
		float z = CrossPlatformInputManager.GetAxis("Vertical");

		Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.AddForce(x * speed, 0, z * speed);
	}
}