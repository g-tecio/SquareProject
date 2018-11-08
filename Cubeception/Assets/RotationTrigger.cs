using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTrigger : MonoBehaviour {

private void OnTriggerEnter2D(Collider2D col){
	if (col.gameObject.tag == "Player")
        {
            transform.Rotate(0,90,0);
            
}

}
}

