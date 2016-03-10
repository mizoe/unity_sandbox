using UnityEngine;
using System.Collections;

public class BallMoving : MonoBehaviour {
    public float speed = 1;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 10),transform.position.y, transform.position.z);
    }
}
