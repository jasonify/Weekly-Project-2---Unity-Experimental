using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (OVRInput.GetUp(OVRInput.RawButton.X) )
        {
            Debug.Log("HELLO");
        }       
	}
}
