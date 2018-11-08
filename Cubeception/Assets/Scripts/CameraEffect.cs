using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RotateCamera(float x = 0, float y = 0, float z = 0){
        transform.Rotate(new Vector3(x, y, z));
    }
}
