using UnityEngine;
using System.Collections;

public class RoomInteraction : MonoBehaviour {
	public GameObject[] bodyParts;
	bool showingBodyParts = true;
	float delayTime = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Time.timeSinceLevelLoad > 3) {
			if(showingBodyParts)
			{
				for (int i = 0; i < 100; i++) {
					GameObject bodyPart = bodyParts[Random.Range(0, bodyParts.Length-1)];
					Instantiate(bodyPart, new Vector3(Random.Range(-5f,5f),4.5f, Random.Range(-5f,5f)),Quaternion.identity);
				}
				showingBodyParts = false;
			}
		}
	}
}
