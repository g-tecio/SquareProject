using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using TMPro;

public class GpgsScript : MonoBehaviour {

	int points = 0;
	public TextMeshProUGUI pointsText;

	public GameObject login;
	// Use this for initialization
	void Start () {
		//Debug
		PlayGamesPlatform.DebugLogEnabled = true;

		//Activate the google play Games platform
		PlayGamesPlatform.Activate();
		LogIn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Login
	public void LogIn()
	{
		Social.localUser.Authenticate((bool sucess) =>
		{
			if(sucess)
			{
				Debug.Log("Login Sucess");
				login.SetActive(true);
			}
			else
			{
				Debug.Log("Login failed");
			}
		});
	}

	public void OnShowLeadBoard()
	{
		PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIz860sswfEAIQAQ");
	}

	public void addScoreLeaderBoard()
	{
		if(Social.localUser.authenticated)
		{
			Social.ReportScore(points, "CgkIz860sswfEAIQAQ", (bool sucess) =>
			{
				if(sucess)
				{
					points = 0;
					pointsText.text = "Points: " + points;
				}
				else
				{
					Debug.Log("Update Score Fail");
				}

			});
		}
	}

	public void OnLogOut()
	{
		((PlayGamesPlatform)Social.Active).SignOut();
	}
}
