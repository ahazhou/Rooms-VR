using UnityEngine;
using System.Collections;

public class Teleport_away : MonoBehaviour {
    private Vector3 startingPosition;
	// Use this for initialization

    public void SetGazedAt(bool gazedAt)
    {
        GetComponent<Renderer>().material.color = gazedAt ?
            Color.cyan : Color.white;
    }


	void Start () {
        startingPosition = transform.localPosition;
        SetGazedAt(false);
	}

   


    public void Reset()
    {
        transform.localPosition = startingPosition;
    }

    public void ToggleVrMode()
    {
        Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
    }

}
