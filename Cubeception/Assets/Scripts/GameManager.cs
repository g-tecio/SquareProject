using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Advertisements;


public class GameManager : MonoBehaviour {

    public GameObject gameOverPanel;
    public GameObject currentScoreText,tapToStart,startButton, speaker, instructions,logo,store,leadboards;

    // public AudioSource audio;

   

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
        Advertisement.Show();
    }

}
