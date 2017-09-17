using UnityEngine;
using System.Collections;

public class Ready : MonoBehaviour {
    Transform ready;
    public float speed;
    public int counting;
    bool continues;
	// Use this for initialization
	void Start () {
        ready = GetComponent<Transform>();
        speed = 0.7f;
        counting = 0;
        continues = false;
	}
	
	// Update is called once per frame
	void Update () {
        ++counting;
        if (ready.position.y <= 37 || continues)
        {
            ready.Translate(Vector3.up * speed);
            counting = 0;
        }

        if (!continues)
        {
            if (counting > 100)
            {
                continues = true;
            }
        }

        if(counting > 500)
        {
            ready.position = new Vector3(0, 0, 0);
        }


	}
}
