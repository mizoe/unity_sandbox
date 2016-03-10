using UnityEngine;
using System.Collections;

public class tama : MonoBehaviour {
	public GameObject player;
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (player);
		}
	}
}