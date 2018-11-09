using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTrigger : MonoBehaviour {
public GameObject floor;
public float speed;

void Start(){
    enabled = false;
}

void Update(){
	goingUp();
}
private void OnTriggerEnter2D(Collider2D col){
	if (col.gameObject.tag == "Player")
        {
            floor.transform.Rotate(0,0,90);
            enabled = true;
}
}

void goingUp(){
	//floor.transform.position = floor.transform.position + (new Vector3(0, speed,0) * Time.deltaTime);
    
}

}


