using UnityEngine;
using System.Collections;

public class tamaDel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("Destroy01", 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Destroy01(){
		Destroy (gameObject);
	}
}
