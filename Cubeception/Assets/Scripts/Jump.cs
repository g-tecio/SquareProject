using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	Rigidbody2D player;

	bool grounded;
	public float jumpforce;

		void Start () {
		player = GetComponent<Rigidbody2D>();
	}


	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0) && grounded == true){
				player.AddForce(Vector2.up * jumpforce);
				grounded = false;
		}
	}


	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Square")
		{
			grounded = true;
		}
	}

}
