using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {
    public GameObject myPrefab;
	// Use this for initialization
	void Start () {
        int totalCubes = 6;
        for (int i = 0; i < totalCubes; i++)
        {
            float perc = i / (float) totalCubes;
            Debug.Log("---one");
            Debug.Log(perc.ToString());
            float x = perc * 3.0f;
            float y = 5.0f;
            float z = 0.0f;

            var newPill = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            newPill.GetComponent<PillScript>().SetScale(0.1f);
            newPill.GetComponent<PillScript>().rotateSpeed = 0.0f; // Random.value; 
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
