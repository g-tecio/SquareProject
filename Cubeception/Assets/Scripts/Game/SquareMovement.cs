using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour {

	public float speed;
    float duration;

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
}
