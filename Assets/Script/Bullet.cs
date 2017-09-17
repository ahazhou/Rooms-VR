using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	int score_count;
	AudioSource pop;
	void Start() {
		score_count = 0;
		pop = GetComponent<AudioSource> ();
	}

	void Update(){

	}

    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.layer == LayerMask.NameToLayer("Balloon"))
        {
			score_count += 1;
            Destroy(other.gameObject);
        }
		pop.Play ();
        Destroy(gameObject);
    }
}
