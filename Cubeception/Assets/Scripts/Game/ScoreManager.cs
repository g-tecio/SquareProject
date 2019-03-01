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
      public int currentScore = 0;

      public int currentScore2 = 0;
	public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI bestScoreText;

     public Missions Script;

     //Missions
     public int scoreAcumlated, scoreStored, scoreAcumlated2, scoreStored2;

     //currency
    public int saveCurrency;
    public int currency;
    public TextMeshProUGUI currencyText;
    public TextMeshProUGUI currencyPlus;
    public GameObject currencyBonus, currencyBonusDoble;
    private bool premium = false;


    void getCurrency()
    {
        currencyText.text = PlayerPrefs.GetInt("Currency", 0).ToString();
    }

	void Start () 
	{
        GetBestScore();
        getCurrency();
        scoreStored = PlayerPrefs.GetInt("a");
      //  print("SCORE ACUMULADO START:" + scoreStored);

        scoreStored2 = PlayerPrefs.GetInt("b");
      //  print("SCORE ACUMULADO SEGUNDO START:" + scoreStored2); 
	}

    void GetBestScore(){
        bestScoreText.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
    }
	
	public void AddScore(){

        Missions missions = gameObject.GetComponent<Missions>();
		currentScore++;
		currentScoreText.text = currentScore.ToString();

        scoreAcumlated = PlayerPrefs.GetInt("a");
            scoreAcumlated = scoreAcumlated + 1;
           // print("SCORE ACUMULADO TIEMPO REAL: " + scoreAcumlated);
            PlayerPrefs.SetInt("a", scoreAcumlated);

            if (missions.claimedR2 == true)
        {
           // print("Se cumplieron las condiciones");
            scoreAcumlated2 = PlayerPrefs.GetInt("b");
            scoreAcumlated2 = scoreAcumlated2 + 1;
           // print("SCORE SEGUNDO: " + scoreAcumlated2);
            PlayerPrefs.SetInt("b", scoreAcumlated2);
        }

        if(currentScore > PlayerPrefs.GetInt("BestScore", 0)){
            bestScoreText.text = currentScore.ToString();
            PlayerPrefs.SetInt("BestScore", currentScore);
        }

        if(missions.claimedR1 == true)
        {
            currentScore2++;
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

        ///Currency
       if (premium == false)
       {

           if (saveCurrency >= 999)
           {
               currencyText.text = "999";
           }

           if (currentScore % 8 == 0)
           {
               currency++;

               saveCurrency = PlayerPrefs.GetInt("Currency", saveCurrency) + 1;
               PlayerPrefs.SetInt("Currency", saveCurrency);
               currencyText.text = PlayerPrefs.GetInt("Currency", saveCurrency).ToString();

               currencyPlus.text = "+" + currency.ToString();
               StartCoroutine(showCurrency());
           }
       }
       else
       {
          // print("YEAH YOU GOT THE PREMIUM VERSION");
           if (saveCurrency >= 999)
           {
               currencyText.text = "999";
           }

           if (currentScore % 8 == 0)
           {
               currency = currency + 2;
              // print("CURRENCYALDOBLE" + currency);
               saveCurrency = PlayerPrefs.GetInt("Currency", saveCurrency) + 2;
               PlayerPrefs.SetInt("Currency", saveCurrency);
               currencyText.text = PlayerPrefs.GetInt("Currency", saveCurrency).ToString();

               currencyPlus.text = "+" + currency.ToString();
               StartCoroutine(showCurrencyDouble());
           }
       }

       //End currency

       if (currentScore > PlayerPrefs.GetInt("BestScore", 0))
       {
           bestScoreText.text = currentScore.ToString();
           PlayerPrefs.SetInt("BestScore", currentScore);
       }

   }

   //Show +1
   IEnumerator showCurrency()
   {
       currencyBonus.SetActive(true);
       yield return new WaitForSeconds(0.5f);
       currencyBonus.SetActive(false);
   }
//Show +2
   IEnumerator showCurrencyDouble()
   {
       currencyBonusDoble.SetActive(true);
       yield return new WaitForSeconds(0.5f);
       currencyBonusDoble.SetActive(false);
   }



   



    void Update()
    {
        saveCurrency = PlayerPrefs.GetInt("Currency", saveCurrency);
        scoreStored = PlayerPrefs.GetInt("a");
       // print("SCORE ACUMULADO START:" + scoreStored);

        scoreStored2 = PlayerPrefs.GetInt("b");
       // print("SCORE ACUMULADO SEGUNDO START:" + scoreStored2);
        

        Missions missions = gameObject.GetComponent<Missions>();
        if (missions.claimedR2 == true)
        {
            scoreAcumlated = 0;
            PlayerPrefs.SetInt("a", scoreAcumlated);
        }

        if (missions.claimedR4 == true)
        {
            scoreAcumlated2 = 0;
            PlayerPrefs.SetInt("b", scoreAcumlated2);
        }

        premium = GameObject.Find("PurchaserManager").GetComponent<PurchaserManager>().Adfree;
    }
}


