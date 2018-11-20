using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner4;
    public GameObject spawner6;
    public GameObject spawner8;
    public GameObject spawner10;


	int currentScore = 0;
	public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI bestScoreText;


	void Start () 
	{
        GetBestScore();
	}

    void GetBestScore(){
        bestScoreText.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
    }
	
	public void AddScore(){
		currentScore++;
		currentScoreText.text = currentScore.ToString();

        if(currentScore > PlayerPrefs.GetInt("BestScore", 0)){
            bestScoreText.text = currentScore.ToString();
            PlayerPrefs.SetInt("BestScore", currentScore);
        }

        if((currentScore % 3) == 0){
            GameObject.Find("Player").GetComponent<Jump>().jumpforce += 1f;
        }

        if (currentScore == 10)
        {
            spawner1.SetActive(true);
            spawner2.SetActive(true);
            spawner4.SetActive(true);
            spawner6.SetActive(true);
            spawner8.SetActive(true);
            spawner10.SetActive(true);
        }
	}
}
