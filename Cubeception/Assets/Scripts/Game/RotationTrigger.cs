﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTrigger : MonoBehaviour {
    public GameObject pivot;
    public float speed;


    void Start(){
        
    }

    void Update(){

     
      
    }
    private void OnTriggerEnter2D(Collider2D col){
    	if (col.gameObject.tag == "Player"){
               
            StartCoroutine(RotateMe(Vector3.back * 90, 0.8f));
            stopMovement();
            //addScore();
            addSpeed();
            //addBackground();
        }
    }

    //void addBackground(){
    //    GameObject.Find("Camera").GetComponent<Camera>().backgroundColor = new Color(Random.value, Random.value, Random.value, 1.0f * Time.deltaTime);
    //}


    void stopMovement(){
        GameObject.Find("Square").GetComponent<SquareMovement>().enabled=false;
    }

    void addSpeed()
    {
        if (GameObject.Find("Square").GetComponent<SquareMovement>().speed < 2.3f)
        {
            GameObject.Find("Square").GetComponent<SquareMovement>().speed += 0.01f;
        }
    }

    //void addScore(){
    //    GameObject.Find("GameManager").GetComponent<ScoreManager>().AddScore();
    //}


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


