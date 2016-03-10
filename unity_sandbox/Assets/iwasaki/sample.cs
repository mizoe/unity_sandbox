using UnityEngine;
using System.Collections;

public class sample : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v = this.transform.position;
		if (Input.GetKey("up")) {
			v.z += 0.5f;
		}
		if (Input.GetKey("down")) {
			v.z -= 0.5f;
		}
		if (Input.GetKey ("left")) {
			v.x -= 0.5f;
		}
		if (Input.GetKey ("right")) {
			v.x += 0.5f;
		}
		this.transform.position = v;
	}
}
