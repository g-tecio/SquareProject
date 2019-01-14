using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Advertisements;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

      public GameObject gameOverPanel;
    public GameObject currentScoreText,tapToStart,startButton, speaker, instructions,logo,store,leadboards,toggleButton;
    bool toggle;
    

    // public AudioSource audio;

     public Image UIBackground;
     int randomBackground;


   

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
        

        //Random Background
       /*  UIBackground = GameObject.Find("PanelImageBackground").GetComponent<Image>();
        randomBackground = Random.Range(1,8);
        switch(randomBackground)
        {
             case 1:
                UIBackground.sprite = Resources.Load<Sprite>("Assets/Backgrounds/gradient1");
                break;
            case 2:
                UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/gradient2");
                break;
            case 3:
                UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/gradient3");
                break;
            case 4:
                UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/gradient4");
                break;
            case 5:
                UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/gradient5");
                break;
            case 6:
                UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/gradient6");
                break;
            case 7:
                UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/gradient7");
                break;
        } */
        
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

    void Start()
    {
      
    }

    void Update()
    {
        if (toggleButton.GetComponent<UnityEngine.UI.Toggle>().isOn == true)
        {
            print("THE SOUND IS MUTED");
            PlayerPrefs.SetInt("select", 1);
            AudioListener.volume = 0f;
        }
        else
        {
            print("THE SOUND IS TURNED ON");
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
