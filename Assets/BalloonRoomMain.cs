using UnityEngine;
using System.Collections;

public class BalloonRoomMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad >= 10) {
			Debug.Log("IM HERE");
			Application.LoadLevel("Main");
		}
	}
}
