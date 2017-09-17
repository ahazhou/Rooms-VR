using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour {

    public void DestroyBalloon()
    {
        Destroy(transform.parent.gameObject);
    }
}
