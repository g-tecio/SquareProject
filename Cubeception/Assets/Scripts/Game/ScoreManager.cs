using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

	int currentScore = 0;
	public TextMeshProUGUI currentScoreText;
	void Start () 
	{
		currentScoreText.text = currentScore.ToString();
	}
	
	public void AddScore(){
		currentScore++;
		currentScoreText.text = currentScore.ToString();

        if((currentScore % 3) == 0){
            GameObject.Find("Player").GetComponent<Jump>().jumpforce += 1f;
        }
	}
}
