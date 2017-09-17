using UnityEngine;
using System.Collections;

public class Baloon_Room_Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad >= 35) {
			Application.LoadLevel("Main");
		}
	
	}
}
