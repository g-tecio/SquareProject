using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGameObject : MonoBehaviour {

	// Use this for initialization

	public GameObject CommingSoon, BtnClose;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowCommingSoon(){
		
		CommingSoon.SetActive(true);
		BtnClose.SetActive(true);
		StartCoroutine(RemoveAfterSeconds(1, CommingSoon));

	}

	IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
	{
		yield return new WaitForSeconds(seconds);
		obj.SetActive(false);
	}

	public void closePopUp(){
		CommingSoon.SetActive(false);
		BtnClose.SetActive(false);
	}





	
}
