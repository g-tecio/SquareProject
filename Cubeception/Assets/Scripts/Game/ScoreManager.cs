using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner4;
    public GameObject spawner6;
    public GameObject spawner8;
    public GameObject spawner10;

    public Image UIBackground;

    public int currentScore = 0;
	public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI bestScoreText;


	void Start () 
	{
        GetBestScore();
        UIBackground = GameObject.Find("BackgroundImage").GetComponent<Image>();
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

        if (currentScore == 10)
        {
            spawner1.SetActive(true);
            spawner2.SetActive(true);
            spawner4.SetActive(true);
            spawner6.SetActive(true);
            spawner8.SetActive(true);
            spawner10.SetActive(true);
        }

        if(currentScore == 1){
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle1");
        }
        if(currentScore == 2){
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle2");
        }
        if (currentScore == 3)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle3");
        }
        if (currentScore == 4)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle4");
        }
        if (currentScore == 5)
        {
            UIBackground.sprite = (Resources.Load<Sprite>("Backgrounds/Blue/Rectangle5"));
        }
        if (currentScore == 6)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle6");
        }
        if (currentScore == 7)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle7");
        }
        if (currentScore == 8)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle8");
        }
        if (currentScore == 9)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle9");
        }
        if(currentScore == 10){
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle9");
        }
        if(currentScore == 11){
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle8");
        }
        if (currentScore == 12)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle7");
        }
        if (currentScore == 13)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle6");
        }
        if (currentScore == 14)
        {
            UIBackground.sprite = (Resources.Load<Sprite>("Backgrounds/Blue/Rectangle5"));
        }
        if (currentScore == 15)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle4");
        }
        if (currentScore == 16)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle3");
        }
        if (currentScore == 17)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle2");
        }
        if (currentScore == 18)
        {
            UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Blue/Rectangle1");
        }

    }
}
