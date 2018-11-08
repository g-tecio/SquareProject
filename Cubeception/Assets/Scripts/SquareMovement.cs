using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		squareMove();
	}

	void squareMove(){
		transform.position = transform.position + (new Vector3(speed, 0,0) * Time.deltaTime);
	}
}
