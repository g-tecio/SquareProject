using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour {

	public float speed;
    bool moveSpectX = true;
    bool moveSpectY = true;
    

    void Start () {

    }



    void Update()
    {
        //if (moveSpectX == true)
        //{
        //    transform.position = transform.position + (new Vector3(speed, 0, 0) * Time.deltaTime);
        //}
        //else if (moveSpectY == true)
        //{
        //    moveSpectX = false;
        //    transform.position = transform.position + (new Vector3(0, speed, 0) * Time.deltaTime);
        //}
    }

    public void RotateSquare(float x = 0, float y = 0, float z = 0){
        transform.Rotate(new Vector3(x, y));
    }



}
