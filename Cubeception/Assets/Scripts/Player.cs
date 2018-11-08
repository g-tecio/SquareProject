using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public float speed;
    bool moveSpectX = true;
    bool moveSpectY = true;
    bool moveSpectXNegative = true;
    bool moveSpectYNegative = true;

    void Start()
    {

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trigger1")
        {
            GameObject.Find("PlayerCamera").GetComponent<CameraEffect>().RotateCamera(x: 0, y: 0, z: 90);
            GameObject.Find("Earth").GetComponent<SquareMovement>().RotateSquare(x: 0, y: 0, z: 90);
            moveSpectX = false;
            moveSpectY = true;
            moveSpectXNegative = false;
            moveSpectYNegative = false;
        }

        if (collision.gameObject.tag == "Trigger2")
        {
            GameObject.Find("PlayerCamera").GetComponent<CameraEffect>().RotateCamera(x: 0, y: 0, z: 90);
            GameObject.Find("Earth").GetComponent<SquareMovement>().RotateSquare(x: 0, y: 0, z: 90);
            moveSpectX = false;
            moveSpectY = false;
            moveSpectXNegative = true;
            moveSpectYNegative = false;
        }

        if (collision.gameObject.tag == "Trigger3")
        {
            GameObject.Find("Earth").GetComponent<SquareMovement>().RotateSquare(x: 0, y: 0, z: 90);
            moveSpectX = false;
            moveSpectY = false;
            moveSpectXNegative = false;
            moveSpectYNegative = true;
        }
        if (collision.gameObject.tag == "Trigger3")
        {
            GameObject.Find("Earth").GetComponent<SquareMovement>().RotateSquare(x: 0, y: 0, z: 90);
            moveSpectX = true;
            moveSpectY = false;
            moveSpectXNegative = false;
            moveSpectYNegative = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }

    void Update()
    {
        if (moveSpectX == true)
        {
            moveSpectY = false;
            moveSpectXNegative = false;
            moveSpectYNegative = false;
            transform.position = transform.position + (new Vector3(speed, 0, 0) * Time.deltaTime);
        }
        else if (moveSpectY == true)
        {
            moveSpectX = false;
            moveSpectXNegative = false;
            moveSpectYNegative = false;
            transform.position = transform.position + (new Vector3(0, speed, 0) * Time.deltaTime);
        }
        else if(moveSpectXNegative == true){

            moveSpectX = false;
            moveSpectY = false;
            moveSpectYNegative = false;
            transform.position = transform.position + (new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
        else if (moveSpectYNegative == true)
        {
            moveSpectY = false;
            moveSpectX = false;
            moveSpectXNegative = false;
            transform.position = transform.position + (new Vector3(0, -speed, 0) * Time.deltaTime);
        }
    }
}
