using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {

	public void StartGane(){
		SceneManager.LoadScene("GameScene");
	}

	public void Instructions(){
		SceneManager.LoadScene(1);
	}

	public void ReturnMenu(){
		SceneManager.LoadScene(0);
	}

}
