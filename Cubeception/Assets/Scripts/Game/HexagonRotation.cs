using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonRotation : MonoBehaviour {

	public float rotateSpeed;
	
	
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation *= Quaternion.Euler(0f, 0f, 90f * rotateSpeed * Time.deltaTime);
		
	}
}
