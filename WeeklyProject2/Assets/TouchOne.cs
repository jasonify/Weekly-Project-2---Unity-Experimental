using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchOne : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float scale = 0.05f;

        if (OVRInput.Get(OVRInput.Button.One)) // Was presssed this frame

  //      if (OVRInput.GetDown(OVRInput.Button.One)) // Was presssed this frame
        {
            Debug.Log("input A");

            GameObject s;
            s = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            // s.transform.position = new Vector3((Random.value * 461) + 10, (Random.value * 300) + 10, 0F);
            s.transform.position = this.transform.position;
            s.transform.rotation = this.transform.rotation;
            s.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
        }

        // Hover
        //        if (OVRInput.GetDown(OVRInput.Touch.Two))
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            GameObject s;

            Debug.Log("input B");
            s = GameObject.CreatePrimitive(PrimitiveType.Cube);
            // s.transform.position = new Vector3((Random.value * 461) + 10, (Random.value * 300) + 10, 0F);
            s.transform.position = this.transform.position;
            s.transform.rotation = this.transform.rotation;

            s.transform.localScale = new Vector3(scale, scale, scale);

        }

    }
}
