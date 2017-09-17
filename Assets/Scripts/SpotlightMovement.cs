using UnityEngine;
using System.Collections;

public class SpotlightMovement : MonoBehaviour {

	public float delta = 2f;  // Amount to move left and right from the start point
	public float speed = 2.0f; 
	public Texture[] textures;
	private Vector3 startPos;

	float timeOn = 0.9f;
	float timeOff = 0.2f;
	float changeTime = 0;

	Light roomLight;
	
	void Start () {
		startPos = transform.position;
		roomLight = transform.GetChild (0).GetComponent<Light> ();
	}
	
	void Update () {
		Vector3 v = startPos;
		v.x += delta * Mathf.Sin (Time.time * speed);
		transform.position = v;

		if (Time.time > changeTime) {
			roomLight.enabled = !roomLight.enabled;
			if (roomLight.enabled) {
				changeTime = Time.time + Random.Range(.1f,timeOn);
			} else {
				changeTime = Time.time + Random.Range(.1f,timeOff);
			}
		}
	}
}
