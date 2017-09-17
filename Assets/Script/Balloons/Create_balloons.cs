using UnityEngine;
using System.Collections;

public class Create_balloons : MonoBehaviour {
    public GameObject balloons;
    public float radius = 60f;
    public float delay = 0.5f;
    public float area_create = 20f;

    public IEnumerator CreateBalloons()
    {
        while (true)
        {
            MakeBalloon();
            yield return new WaitForSeconds(delay);
        }
    }

    void MakeBalloon()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        GameObject thisBalloon = Instantiate(balloons, transform.position + Vector3.forward * Random.Range(-area_create, area_create) + Vector3.right * Random.Range(-area_create, area_create), Quaternion.identity) as GameObject;
        thisBalloon.transform.GetChild(0).GetComponent<Renderer>().material.color = newColor;
    }
}
