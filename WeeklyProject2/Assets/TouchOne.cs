using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchOne : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("input A");
        }

        if (OVRInput.GetDown(OVRInput.Touch.Two))
        {
            Debug.Log("input B");
        }

    }
}
