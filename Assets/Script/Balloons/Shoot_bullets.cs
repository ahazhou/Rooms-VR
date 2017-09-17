using UnityEngine;
using System.Collections;

public class Shoot_bullets : MonoBehaviour {
    public Rigidbody projectile;
    AudioSource shoot_bullet;
    public float speed = 100;

    void Start()
    {
        shoot_bullet = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update ()
    {
        if (Cardboard.SDK.Triggered)
        {
            shoot_bullet.Play();
            Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));//
        }
    }
}
