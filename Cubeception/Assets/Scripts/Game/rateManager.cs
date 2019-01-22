using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rateManager : MonoBehaviour
{
 
    public string ANDROID_RATE_URL = "market://details?id=com.games.cartwheelgalaxy.qbix";
    public string IOS_RATE_URL = "Aquí va el link de IOS";

    public void RateApp()
    {
    #if UNITY_ANDROID
        Application.OpenURL(ANDROID_RATE_URL);
    #elif UNITY_IPHONE
        Application.OpenURL(IOS_RATE_URL);
    #endif

    }
}
