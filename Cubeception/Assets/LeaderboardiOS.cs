using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardiOS : MonoBehaviour
{
    
    int score;
//    string leaderboardID = "QbixLeadiOS01";
    // Start is called before the first frame update
    void Start()
    {
    
    }
    // Update is called once per frame
    void Update()
    {
        score = GameObject.Find("GameManager").GetComponent<ScoreManager>().currentScore;   
    }
    
public void ShowLB(){
    Social.ShowLeaderboardUI();
}
}

