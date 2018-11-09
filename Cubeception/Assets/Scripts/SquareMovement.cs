using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour {

	public float speed;
  
    

  public void Start () {
        enabled = true;
    }



    void Update()
    {
        Movement();
    }

    void Movement(){
        transform.position = transform.position + (new Vector3(speed,0,0) * Time.deltaTime);
    }

   
    



}
