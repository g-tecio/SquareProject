using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using GoogleMobileAds.Api;



public class GameManager : MonoBehaviour {

      public GameObject gameOverPanel;
    public GameObject currentScoreText,tapToStart,startButton, speaker, instructions,logo,store,leadboards,toggleButton, noAdsButton;
    bool toggle;
    int numGame;

    string adUnitId;
    InterstitialAd interstitial;

     int randomBackground;
     public string videoPlacement = "video";
     public bool testMode = false;
    public const string gameID = "2988439";
    
   private void RequestInterstitial()
{
    #if UNITY_ANDROID
        string adUnitId = "ca-app-pub-5267056163100832/8575852612";
    #elif UNITY_IPHONE
        string adUnitId = "";
    #else
        string adUnitId = "unexpected_platform";
    #endif

    // Initialize an InterstitialAd.
    InterstitialAd interstitial = new InterstitialAd(adUnitId);
    // Create an empty ad request.
    AdRequest request = new AdRequest.Builder().Build();
    // Load the interstitial with the request.
    interstitial.LoadAd(request);
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

        if (interstitial.IsLoaded()) {
    interstitial.Show();
    }

        
        
    }

  

    void Start () {
        Advertisement.Initialize (gameID, testMode);
         numGame = PlayerPrefs.GetInt("numGame");
         
    }

    
    void Update()
    {
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
    }

    public void GameOver(){
        StartCoroutine(GameOverCoroutine());
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
              Advertisement.Show(videoPlacement);
        }
    }

}
