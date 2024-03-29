﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class RotationTrigger : MonoBehaviour {
    public GameObject pivot;
    public float speed;

    private void OnTriggerEnter2D(Collider2D col){
    	if (col.gameObject.tag == "Player"){
               
            StartCoroutine(RotateMe(Vector3.back * 90, 0.8f));
            stopMovement();
            addSpeed(); 
            MoreJump();
            AddGravity();
        }
    }

    void AddGravity(){
        if(GameObject.Find("Player").GetComponent<Rigidbody2D>().gravityScale < 2.85){
            GameObject.Find("Player").GetComponent<Rigidbody2D>().gravityScale += 0.05f;
        }
    }

    void MoreJump(){
        if(GameObject.Find("Player").GetComponent<Jump>().jumpforce < 498.75){
            GameObject.Find("Player").GetComponent<Jump>().jumpforce += 8.75f;
        }
    }


    void stopMovement(){
        GameObject.Find("Square").GetComponent<SquareMovement>().enabled=false;
    }

    void addSpeed()
    {
        if (GameObject.Find("Square").GetComponent<SquareMovement>().speed < 2.85f)
        {
            GameObject.Find("Square").GetComponent<SquareMovement>().speed += 0.05f;
        }
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


