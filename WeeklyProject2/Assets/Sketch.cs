using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {
    public GameObject myPrefab;
	// Use this for initialization
	void Start () {
        var newPill = Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
