using UnityEngine;
using System.Collections;

public class tvRoom_static : MonoBehaviour {

    public Texture[] frames;
    public float framesPerSecond = 10.0f;
    int k = 0;
    float j = 0;

    AudioSource tv_noise;
    Renderer renderer;
	// Use this for initialization
	void Start () {
        renderer = GetComponent<Renderer>();
        tv_noise = GetComponent<AudioSource>();
        tv_noise.volume = 0.15f;
        k = 500;
        j = 0.23f;
	}
	
	// Update is called once per frame
	void Update () {
        --k;
        int index = (int)(Time.time * framesPerSecond) % frames.Length;
        renderer.material.mainTexture = frames[index];

        if (k < -2100 && j >= -0.01)
        {
            tv_noise.volume = j;
            j = j - 0.01f;
        }
	}
}
