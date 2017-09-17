using UnityEngine;
using System.Collections;

public class Bullet_behavior : MonoBehaviour {

    public float bulletSpeed = 5f;
    void Update()
    {
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }
}
