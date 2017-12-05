using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillScript : MonoBehaviour {
    public Vector3 rotateAround = new Vector3(0, 1, 0);
    public float rotateSpeed = 1.0f;
    public Vector3 spinSpeed = Vector3.zero;
	// Use this for initialization
	void Start () {
        // this.spinSpeed = new Vector3(Random.value, Random.value, Random.value);
	}
	
	// Update is called once per frame
	void Update () {
        // this.transform.Rotate(spinSpeed);
        // this.transform.RotateAround(Vector3.zero, rotateAround, rotateSpeed);
	}

    public void SetScale(float scale)
    {
        this.transform.localScale = new Vector3(scale, scale, scale);
    }

    private void OnMouseDown()
    {
        // Destroy(gameObject);
        /*
        this.spinSpeed.x *= 2;
        this.spinSpeed.y *= 2;
        this.spinSpeed.z *= 2;
        rotateAround.y = -1 * rotateAround.y;
        */
    }

    private void OnMouseEnter()
    {
        Debug.Log("Mouse over", gameObject);
    }
}
