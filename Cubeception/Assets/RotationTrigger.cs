using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTrigger : MonoBehaviour {
public GameObject floor;
public float speed;


void Update(){
	
}
private void OnTriggerEnter2D(Collider2D col){
	if (col.gameObject.tag == "Player")
        {
            floor.transform.Rotate(0,0,90);
			
            
}
}

void goingUp(){
	floor.transform.position = floor.transform.position + (new Vector3(0, speed,0) * Time.deltaTime);
}

}


