using UnityEngine;
using System.Collections;

public class WallMovement : MonoBehaviour {
	 AudioSource wallClosingIn;
	 AudioSource heartbeat;
	 AudioSource scream;
	bool isWallPlaying = false;
	bool isScreamlPlaying = false;
	bool isWallMoving = false;
	bool wallEndedMoving = false;
	// Use this for initialization
	void Start () {
		wallClosingIn = GetComponents<AudioSource> ()[0];
		heartbeat = GetComponents<AudioSource> ()[1];
		scream = GetComponents<AudioSource> ()[2];

		wallClosingIn.PlayDelayed (8);
		heartbeat.PlayScheduled(45);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > 8 && !wallEndedMoving) {
//			if (!isWallPlaying) {
//				wallClosingIn.Play ();
//				isWallPlaying=true;
//			}
		isWallMoving = true;
			if(isWallMoving)
				transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + -.01f);
		}
		if (transform.position.z <= -.5f) {
			if(!isScreamlPlaying)
			{
				scream.Play();
				isScreamlPlaying = true;
				isWallMoving = false;
				wallEndedMoving = true;
				Application.LoadLevel("roomTV");
			}
		}
	}
}