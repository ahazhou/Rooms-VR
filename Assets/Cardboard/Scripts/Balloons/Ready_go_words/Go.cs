using UnityEngine;
using System.Collections;

public class Go : MonoBehaviour
{
    public Create_balloons balloonSpawner;
    Transform go;
    public float speed;
    int counting;
    bool continues;
    bool alreadyMadeBalloons = false;
    // Use this for initialization
    void Start()
    {
        go = GetComponent<Transform>();
        speed = 0.7f;
        counting = 0;
        continues = false;
    }

    // Update is called once per frame
    void Update()
    {
        ++counting;
        if (go.position.y <= 60 || continues)
        {
            go.Translate(Vector3.up * speed);
            counting = 0;
        }
        else if (go.position.y > 60 && !alreadyMadeBalloons)
        {
            balloonSpawner.StartCoroutine(balloonSpawner.CreateBalloons());
            alreadyMadeBalloons = true;
        }

        if (!continues)
        {
            if (counting > 100)
            {
                continues = true;
            }
        }

        if (counting > 400)
        {
            go.Translate(Vector3.back * speed* 0.2f);
            counting = 0;
        }

        if (counting > 1000)
        {
            go.position = new Vector3(0, -45.1f, 0);
        }

    }
}
