using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowGameObject : MonoBehaviour {

	// Use this for initialization

	public GameObject CommingSoon, BtnClose,missionsPanel,gameOverPanel,storePanel,backButton,boughtPanel;
	
	public GameObject score;
    public GameObject buttonStore, buttonInfo, buttonNoads, ButtonSound, buttonLeaderboard, buttonTapToStart;

	public GameObject tutorial, gameLogo;

	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	 if( storePanel.activeInHierarchy == true)
       {


       }else{

	   }	
	}

	public void ShowCommingSoon(){
		
		CommingSoon.SetActive(true);
		BtnClose.SetActive(true);
		StartCoroutine(RemoveAfterSeconds(1, CommingSoon));

	}

	IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
	{
		yield return new WaitForSeconds(seconds);
		obj.SetActive(false);
	}

	public void closePopUp(){
		CommingSoon.SetActive(false);
		BtnClose.SetActive(false);
	}

	  public void ShowMissions()
    {
        missionsPanel.gameObject.SetActive(true);
        gameOverPanel.gameObject.SetActive(false);

		score.gameObject.SetActive(false);

    }

    public void CloseMissions()
    {
        missionsPanel.gameObject.SetActive(false);
        gameOverPanel.gameObject.SetActive(true);

		score.gameObject.SetActive(true);

    }

	public void ShowStore()
	{
		storePanel.gameObject.SetActive(true);
		backButton.gameObject.SetActive(true);

		buttonStore.gameObject.SetActive(false);
        buttonInfo.gameObject.SetActive(false);
        buttonNoads.gameObject.SetActive(false);
        ButtonSound.gameObject.SetActive(false);
        buttonLeaderboard.gameObject.SetActive(false);
		buttonTapToStart.gameObject.SetActive(false);

		


	}

	public void CloseStore()
	{
		storePanel.gameObject.SetActive(false);
		backButton.gameObject.SetActive(false);

		buttonStore.gameObject.SetActive(true);
        buttonInfo.gameObject.SetActive(true);
        buttonNoads.gameObject.SetActive(true);
        ButtonSound.gameObject.SetActive(true);
        buttonLeaderboard.gameObject.SetActive(true);
		buttonTapToStart.gameObject.SetActive(true);


	}

	public void CloseBought()
	{
		boughtPanel.gameObject.SetActive(false);
	}

	public void ShowTutorial()
	{
		tutorial.gameObject.SetActive(true);
		gameLogo.gameObject.SetActive(false);

		buttonStore.gameObject.SetActive(false);
        buttonNoads.gameObject.SetActive(false);
        ButtonSound.gameObject.SetActive(false);
        buttonLeaderboard.gameObject.SetActive(false);
		buttonTapToStart.gameObject.SetActive(false);

	
	}

	public void CloseTutorial()
	{
		tutorial.gameObject.SetActive(false);
		gameLogo.gameObject.SetActive(true);

		buttonStore.gameObject.SetActive(true);
        buttonNoads.gameObject.SetActive(true);
        ButtonSound.gameObject.SetActive(true);
        buttonLeaderboard.gameObject.SetActive(true);
		buttonTapToStart.gameObject.SetActive(true);
	}
}
