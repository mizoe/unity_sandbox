using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject go;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(go, transform.position, transform.rotation);
        }
        
	}
}
