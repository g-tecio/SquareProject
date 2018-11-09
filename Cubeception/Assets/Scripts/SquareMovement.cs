using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour {

	public float speed;
  
    

    void Start () {

    }



    void Update()
    {
        Rotation();
    }

    void Rotation(){
        transform.position = transform.position + (new Vector3(speed,0,0) * Time.deltaTime);
    }

   
    



}
