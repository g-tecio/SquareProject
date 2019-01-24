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
    public static bool showInterstitialAd;

    
     private void RequestInterstitial()
     {
         #if UNITY_ANDROID
             string adUnitId = "ca-app-pub-5267056163100832/3758586307";
         #elif UNITY_IPHONE
             string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
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

    public void GameOver(){
        StartCoroutine(GameOverCoroutine());
       #if UNITY_ANDROID
        Debug.Log("Reporting score " + score + " on leaderboard " + leaderboardID);
        Social.ReportScore(score, leaderboardID, success =>
        {
            Debug.Log(success ? "Reported score successfully" : "Failed to report score");
        });

#endif
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            Debug.Log("Reporting score " + score + " on leaderboard " + leaderboardID);
            Social.ReportScore(score, leaderboardID, success =>
            {
                Debug.Log(success ? "Reported score successfully" : "Failed to report score");
            });
        }
    }

    IEnumerator GameOverCoroutine(){
        yield return new WaitForSecondsRealtime(0.3f);
        Time.timeScale = 0.01f;
        yield return new WaitForSecondsRealtime(0.5f);
        gameOverPanel.SetActive(true);
        GetComponent<ScoreManager>().currentScoreText.color = Color.white;
        yield break;
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        numGame = numGame + 1;
        PlayerPrefs.SetInt("numGame", numGame);
        if (numGame % 3 == 0)
        {
            ShowInterstitial();
        }
    }
}
