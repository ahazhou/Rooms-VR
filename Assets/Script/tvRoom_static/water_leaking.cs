using UnityEngine;
using System.Collections;


public class water_leaking : MonoBehaviour {
    public int k;
    float flow_up;
    Transform water;
    AudioSource liquid;
    // Use this for initialization
	void Start () {
        k = 500;
        flow_up = 0.02f;
        water = GetComponent<Transform>();
        water.localScale = new Vector3(1, -1, 1);
        liquid = GetComponent<AudioSource>();
        liquid.volume = 0.15f;
	}
	
	// Update is called once per frame
	void Update () {
        --k;
        if (k < -2100 && ((water.position.y) <= 2) )
        {
            water.Translate(Vector3.up * flow_up);
            water.localScale = new Vector3(water.localScale.x + 0.05f, water.localScale.y + 0.05f, water.localScale.z + 0.05f);
            if ((k + 10) % 300 == 0)
            {
                liquid.Play();
            }
        }
	}
}
