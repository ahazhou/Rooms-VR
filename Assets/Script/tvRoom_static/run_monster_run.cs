using UnityEngine;
using System.Collections;

public class run_monster_run : MonoBehaviour {
    public float time_;
    public bool once;
    public int count_down;
    public int apparition_appears;

    Transform curr_location;
    Animator ani;
    AudioSource[] audio;
    AudioSource audio1;
    AudioSource audio2;
	// Use this for initialization
	void Start () {
        ani = GetComponent<Animator>();
        curr_location = GetComponent<Transform>();
        audio = GetComponents<AudioSource>();
        once = false;
        apparition_appears = -1000;
        count_down = 500;
        time_ = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        //Figure out when to change
        if (count_down > -60000)
        {
            --count_down;
        }

        if (count_down == apparition_appears)
        {
            //camera at 0,2,-6 
            curr_location.position = new Vector3(0, 0.3f, -3.8f);
            curr_location.rotation = Quaternion.AngleAxis(180, Vector3.up);
            audio2 = audio[0];
            audio2.Play();
        }


        if (count_down == -1500)
        {
            audio1 = audio[3];
            audio1.Play();

        }
        else if (count_down == -1550)
        {
            audio1.Play();
        }
        else if (count_down == -1610)
        {
            audio1.Play();
        }
        else if (count_down == -1690)
        {
            audio1.Play();
        }
        else if (count_down == -1720)
        {
            audio1 = audio[0];
            audio1.Play();
        }
        else if (count_down == -1900)
        {
            audio2 = audio[4];
            audio2.Play();
        }
        else if (count_down == -2100)
        {
            audio1 = audio[2];
            audio1.Play();
        }



        if (count_down == apparition_appears - 200)
        {
            curr_location.position = new Vector3(6, 0, 10);
        }
      
        if (count_down < -40 && count_down > apparition_appears)
        {
            if (curr_location.position.x > -5.4 &&
                curr_location.position.z < 9.3 &&
                !once)
            {
                audio1 = audio[1];
                audio1.Play();
                once = true;
            }

            if (curr_location.position.x < 6)
            {
                curr_location.Translate(Vector3.forward * time_);
                ani.SetBool("IsRunning", true);
                if (curr_location.position.x >= 5)
                    ani.SetBool("IsRunning", false);
            }
        }
         
	}
}
