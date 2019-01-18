using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;



public class GameManager : MonoBehaviour {

      public GameObject gameOverPanel;
    public GameObject currentScoreText,tapToStart,startButton, speaker, instructions,logo,store,leadboards,toggleButton, noAdsButton, commingSoon,closeBtn;
    bool toggle;
    int numGame;
   


   

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
        closeBtn.SetActive(false);
        commingSoon.SetActive(false);
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

        }
    }

    



}
