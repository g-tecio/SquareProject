﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTrigger : MonoBehaviour {
public GameObject floor;
public float speed;

void Start(){
    enabled = false;
}

void Update(){
	Rotation();
}
private void OnTriggerEnter2D(Collider2D col){
	if (col.gameObject.tag == "Player")
        {
            enabled = true;
}
}

void Rotation(){
	transform.Rotate(0,0, -speed * Time.deltaTime, Space.World);
    
}

}


