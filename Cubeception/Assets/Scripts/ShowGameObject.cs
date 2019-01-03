using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGameObject : MonoBehaviour {

	// Use this for initialization

	public GameObject CommingSoon;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowCommingSoon(){
		CommingSoon.SetActive(true);
	}
}
