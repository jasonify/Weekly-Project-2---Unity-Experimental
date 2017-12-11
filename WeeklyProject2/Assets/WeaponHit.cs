using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (LineRenderer))]

public class WeaponHit : MonoBehaviour {

    public LineRenderer lr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.collider)
            {
                lr.SetPosition(1, new Vector3(0,0, hit.distance));
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("HELLO");

        }
    }
		
	
}
