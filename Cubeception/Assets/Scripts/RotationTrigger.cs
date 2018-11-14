using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTrigger : MonoBehaviour {
public GameObject pivot;
public float speed;
GameObject square;

void Start(){
    
}

void Update(){

 
  
}
private void OnTriggerEnter2D(Collider2D col){
	if (col.gameObject.tag == "Player")
        {
           
            StartCoroutine(RotateMe(Vector3.back * 90, 0.8f));
            //Rotation();
            stopMovement();
            GameObject.Find("GameManager").GetComponent<ScoreManager>().AddScore();
                        
}
}

void Rotation(){
	//pivot.transform.Rotate(0,0, -90);    
}

void stopMovement(){
GameObject.Find("Square").GetComponent<SquareMovement>().enabled=false;
}






IEnumerator RotateMe(Vector3 byAngles, float time){
    var fromAngle = pivot.transform.rotation;
    var toAngle = Quaternion.Euler(pivot.transform.eulerAngles + byAngles);
    for(var t = 0f; t < 1; pivot.transform.rotation = toAngle, t+= Time.deltaTime/time){
        pivot.transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
        yield return null;
    }
    GameObject.Find("Square").GetComponent<SquareMovement>().enabled=true;
}



}


