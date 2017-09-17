using UnityEngine;
using System.Collections;

public class tvRoom_changing_light_intensity : MonoBehaviour {

    Light light;
	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        light.intensity = Random.Range(0.0f, 3.0f);
	}
}
