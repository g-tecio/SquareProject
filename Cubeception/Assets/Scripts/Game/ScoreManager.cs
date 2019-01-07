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

     //currency
    public int saveCurrency;
    public int currency;
    public TextMeshProUGUI currencyText;
    public TextMeshProUGUI currencyPlus;
    public GameObject currencyBonus;
    private bool premium = false;



	void Start () 
	{
        GetBestScore();
//        UIBackground = GameObject.Find("BackgroundImage").GetComponent<Image>();
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
        

    //     if(currentScore == 1){
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB2");
    //     }
    //     if(currentScore == 2){
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB3");
    //     }
    //     if (currentScore == 3)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB4");
    //     }
    //     if (currentScore == 4)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB5");
    //     }
    //     if (currentScore == 5)
    //     {
    //         UIBackground.sprite = (Resources.Load<Sprite>("Backgrounds/RectangleB6"));
    //     }
    //     if (currentScore == 6)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB7");
    //     }
    //     if (currentScore == 7)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB8");
    //     }
    //     if (currentScore == 8)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB9");
    //     }
    //     if (currentScore == 9)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB10");
    //     }
    //     if (currentScore == 10)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB9");
    //     }
    //     if (currentScore == 11)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB8");
    //     }
    //     if (currentScore == 12)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB7");
    //     }
    //     if (currentScore == 13)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB6");
    //     }
    //     if (currentScore == 14)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB5");
    //     }
    //     if (currentScore == 15)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB4");
    //     }
    //     if (currentScore == 16)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB3");
    //     }
    //     if (currentScore == 17)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/RectangleB2");
    //     }
    //     if (currentScore == 18)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/Rectangle1");
    //     }
    //     if (currentScore == 19)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle");
    //     }
    //     if (currentScore == 20)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-1");
    //     }
    //     if (currentScore == 21)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-2");
    //     }
    //     if (currentScore == 22)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-3");
    //     }
    //     if (currentScore == 23)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-4");
    //     }
    //     if (currentScore == 24)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-5");
    //     }
    //     if (currentScore == 25)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-6");
    //     }
    //     if (currentScore == 26)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-7");
    //     }
    //     if (currentScore == 27)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-8");
    //     }
    //     if (currentScore == 28)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-7");
    //     }
    //     if (currentScore == 29)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-6");
    //     }
    //     if (currentScore == 30)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-5");
    //     }
    //     if (currentScore == 31)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-4");
    //     }
    //     if (currentScore == 32)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-3");
    //     }
    //     if (currentScore == 33)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-2");
    //     }
    //     if (currentScore == 34)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle-1");
    //     }
    //     if (currentScore == 35)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds2/Rectangle");
    //     }
    //     if (currentScore == 36)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle");
    //     }
    //     if (currentScore == 37)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-1");
    //     }
    //     if (currentScore == 38)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-2");
    //     }
    //     if (currentScore == 39)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-3");
    //     }
    //     if (currentScore == 40)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-4");
    //     }
    //     if (currentScore == 41)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-5");
    //     }
    //     if (currentScore == 42)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-6");
    //     }
    //     if (currentScore == 43)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-7");
    //     }
    //     if (currentScore == 44)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-8");
    //     }
    //     if (currentScore == 45)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-9");
    //     }
    //     if (currentScore == 46)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-8");
    //     }
    //     if (currentScore == 47)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-7");
    //     }
    //     if (currentScore == 48)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-6");
    //     }
    //     if (currentScore == 49)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-5");
    //     }
    //     if (currentScore == 50)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-4");
    //     }
    //     if (currentScore == 51)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-3");
    //     }
    //     if (currentScore == 52)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-2");
    //     }
    //     if (currentScore == 53)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle-1");
    //     }
    //     if (currentScore == 54)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds3/Rectangle");
    //     }
    //     if (currentScore == 55)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle");
    //     }
    //     if (currentScore == 56)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-1");
    //     }
    //     if (currentScore == 57)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-2");
    //     }
    //     if (currentScore == 58)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-3");
    //     }
    //     if (currentScore == 59)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-4");
    //     }
    //     if (currentScore == 60)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-5");
    //     }
    //     if (currentScore == 61)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-6");
    //     }
    //     if (currentScore == 62)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-7");
    //     }
    //     if (currentScore == 63)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-8");
    //     }
    //     if (currentScore == 64)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-9");
    //     }
    //     if (currentScore == 65)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-8");
    //     }
    //     if (currentScore == 66)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-7");
    //     }
    //     if (currentScore == 67)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-6");
    //     }
    //     if (currentScore == 68)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-5");
    //     }
    //     if (currentScore == 69)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-4");
    //     }
    //     if (currentScore == 70)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-3");
    //     }
    //     if (currentScore == 71)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-2");
    //     }
    //     if (currentScore == 72)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle-1");
    //     }
    //     if (currentScore == 73)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds4/Rectangle");
    //     }
    //     if (currentScore == 74)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle");
    //     }
    //     if (currentScore == 75)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-1");
    //     }
    //     if (currentScore == 76)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-2");
    //     }
    //     if (currentScore == 77)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-3");
    //     }
    //     if (currentScore == 78)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-4");
    //     }
    //     if (currentScore == 79)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-5");
    //     }
    //     if (currentScore == 80)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-6");
    //     }
    //     if (currentScore == 81)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-7");
    //     }
    //     if (currentScore == 82)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-8");
    //     }
    //     if (currentScore == 83)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-9");
    //     }
    //     if (currentScore == 84)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-8");
    //     }
    //     if (currentScore == 85)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-7");
    //     }
    //     if (currentScore == 86)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-6");
    //     }
    //     if (currentScore == 87)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-5");
    //     }
    //     if (currentScore == 88)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-4");
    //     }
    //     if (currentScore == 89)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-3");
    //     }
    //     if (currentScore == 90)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-2");
    //     }
    //     if (currentScore == 91)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle-1");
    //     }
    //     if (currentScore == 92)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds5/Rectangle");
    //     }
    //     if (currentScore == 93)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle");
    //     }
    //     if (currentScore == 94)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-1");
    //     }
    //     if (currentScore == 95)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-2");
    //     }
    //     if (currentScore == 96)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-3");
    //     }
    //     if (currentScore == 97)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-4");
    //     }
    //     if (currentScore == 98)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-5");
    //     }
    //     if (currentScore == 99)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-6");
    //     }
    //     if (currentScore == 100)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-7");
    //     }
    //     if (currentScore == 101)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-8");
    //     }
    //     if (currentScore == 102)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-9");
    //     }
    //     if (currentScore == 103)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-8");
    //     }
    //     if (currentScore == 104)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-7");
    //     }
    //     if (currentScore == 105)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-6");
    //     }
    //     if (currentScore == 106)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-5");
    //     }
    //     if (currentScore == 107)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-4");
    //     }
    //     if (currentScore == 108)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-3");
    //     }
    //     if (currentScore == 109)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-2");
    //     }
    //     if (currentScore == 110)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle-1");
    //     }
    //     if (currentScore == 111)
    //     {
    //         UIBackground.sprite = Resources.Load<Sprite>("Backgrounds6/Rectangle");
    //     }
    // }
}
}
