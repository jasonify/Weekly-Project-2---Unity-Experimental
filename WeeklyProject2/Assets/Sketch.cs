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
            for (int j = 0; j < totalCubes; j++)
            {
                float perc = i / (float) totalCubes;
                float x = perc * 3.0f;
                float y = j * 1.0f;
                float z = 0.0f;

                var newPill = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
                newPill.GetComponent<PillScript>().SetScale(perc);
                newPill.GetComponent<PillScript>().rotateSpeed = Random.value + 1.0f;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
