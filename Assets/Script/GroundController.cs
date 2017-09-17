using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "BodyPart") {
			Debug.Log("ENTERED");
		}
		
	}
}
