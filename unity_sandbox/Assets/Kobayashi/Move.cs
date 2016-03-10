using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed = 10;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxisRaw("Horizontal");
		float z = Input.GetAxisRaw("Vertical");
		Vector3 direction = new Vector3 (x,0,z).normalized;
		move(direction);
	}

	void move(Vector3 direction){
		Vector3 pos = transform.position;
		pos += direction * speed * Time.deltaTime;
		transform.position = pos;
	}
}
