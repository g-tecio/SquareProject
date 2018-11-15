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
        
        Movement(speed);
    }

    void Movement(float speed){
        transform.position = transform.position + (new Vector3(speed,0,0) * Time.deltaTime);
    }

    //public void Scale(float scale){
    //    transform.localScale += new Vector3(0, scale, 0);
    //}

}
