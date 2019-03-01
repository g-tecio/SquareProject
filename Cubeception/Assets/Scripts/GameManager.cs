using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using GoogleMobileAds.Api;



public class GameManager : MonoBehaviour {
    private InterstitialAd interstitial;
      public GameObject gameOverPanel;
    public GameObject currentScoreText,tapToStart,startButton, speaker, instructions,logo,store,leadboards,toggleButton, noAdsButton, commingSoon,closeBtn;
    int numGame;
    public long score;
    string leaderboardID = "CgkIz860sswfEAIQAQ";
    string leaderboardiOS = "QbixLeadiOS01";
    public static bool showInterstitialAd;

    public bool loginSuccessful;

    public bool Adfree;

    
     private void RequestInterstitial()
     {
         #if UNITY_ANDROID
             string adUnitId = "ca-app-pub-5267056163100832/3758586307";
         #elif UNITY_IPHONE
             string adUnitId = "ca-app-pub-5267056163100832/4107812340";
         #else
             string adUnitId = "unexpected_platform";
         #endif
                 
         // Create an interstitial.
         this.interstitial = new InterstitialAd(adUnitId);
         // Load an interstitial ad.
         this.interstitial.LoadAd(this.CreateAdRequest());
     }
     
     // Returns an ad request
     private AdRequest CreateAdRequest()
     {
         return new AdRequest.Builder().Build();
     }
     
     private void ShowInterstitial()
     { 
         if (interstitial.IsLoaded())
         {
             interstitial.Show(); 
         }
     }

    void Awake()
    {
        Time.timeScale = 0;
        currentScoreText.SetActive(false);
        tapToStart.SetActive(true);
        startButton.SetActive(true);
        speaker.SetActive(true);
        instructions.SetActive(true);
        logo.SetActive(true);
        store.SetActive(true);
        leadboards.SetActive(true);
        noAdsButton.SetActive(true);

          if (PlayerPrefs.HasKey("select"))
        {
            if (PlayerPrefs.GetInt("select") == 1)
            {
                toggleButton.GetComponent<UnityEngine.UI.Toggle>().isOn = true;
                AudioListener.volume = 0f;
            }
            else
            {
                toggleButton.GetComponent<UnityEngine.UI.Toggle>().isOn = false;
                AudioListener.volume = 1f;
            }
        }

    }

    void Start () {
         numGame = PlayerPrefs.GetInt("numGame");
         RequestInterstitial();
         Application.targetFrameRate = 300;
        QualitySettings.vSyncCount = 1;
        AuthenticateUser();
    }

    void Update()
    {
        score = GameObject.Find("GameManager").GetComponent<ScoreManager>().currentScore;
       Debug.Log("SCORE DE GAME MANAGER " + score);
        if (toggleButton.GetComponent<UnityEngine.UI.Toggle>().isOn == true)
        {
            
            PlayerPrefs.SetInt("select", 1);
            AudioListener.volume = 0f;
        }
        else
        {
            
            PlayerPrefs.SetInt("select", 0);
            AudioListener.volume = 1f;
        }

         Adfree = GameObject.Find("PurchaserManager").GetComponent<PurchaserManager>().Adfree;

         if (Adfree == true)
         {
             AdMob.bannerView.Destroy();
             
         }
        
    }

    public void startGame() {
        Time.timeScale = 1;
        currentScoreText.SetActive(true);
        tapToStart.SetActive(false);
        startButton.SetActive(false);
        speaker.SetActive(false);
        instructions.SetActive(false);
        logo.SetActive(false);
         store.SetActive(false);
        leadboards.SetActive(false);
        noAdsButton.SetActive(false);
        closeBtn.SetActive(false);
        commingSoon.SetActive(false);
    }

    void AuthenticateUser(){
        Social.localUser.Authenticate((bool success) => {
        if(success)
        {
        loginSuccessful = true;
        Debug.Log("si se logeo");
        }else
        {
        Debug.Log("no se logeo");
        }});
}

    public void GameOver(){
        StartCoroutine(GameOverCoroutine());
      /*  #if UNITY_ANDROID
        Debug.Log("Reporting score " + score + " on leaderboard " + leaderboardID);
        Social.ReportScore(score, leaderboardID, success =>
        {
            Debug.Log(success ? "Reported score successfully" : "Failed to report score");
        });
        #endif */
        #if !UNITY_EDITOR
        if(loginSuccessful)
        {
        Social.ReportScore(score, leaderboardiOS, (bool success) => {
        if(success)
        Debug.Log("Se subio el score");
        // handle success or failure
        });
        }
        else
        {
        Social.localUser.Authenticate((bool success) => {
        if(success)
        {
        loginSuccessful = true;
        Social.ReportScore(score ,leaderboardiOS, (bool successful) => {
        // handle success or failure
        });
        }
    else
    {
    Debug.Log("nel compa");
    }
    // handle success or failure
    });
    }
    #endif
    


   

    IEnumerator GameOverCoroutine(){
        yield return new WaitForSecondsRealtime(0.3f);
        Time.timeScale = 0.01f;
        yield return new WaitForSecondsRealtime(0.5f);
        gameOverPanel.SetActive(true);
        GetComponent<ScoreManager>().currentScoreText.color = Color.white;
        yield break;
    }

    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        numGame = numGame + 1;
        PlayerPrefs.SetInt("numGame", numGame);
        if (numGame % 3 == 0 && Adfree == false)
        {
            ShowInterstitial();
        }
        
    }
    
}

