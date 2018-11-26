using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject gameOverPanel;
   

    void Awake()
    {
        Time.timeScale = 1.0f;
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
    }

}
