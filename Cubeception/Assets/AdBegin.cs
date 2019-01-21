using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdBegin : MonoBehaviour
{

    bool hasShownAdOneTime;
   private InterstitialAd interstitial;
 
     private void RequestInterstitial()
     {
         #if UNITY_ANDROID
             string adUnitId = "ca-app-pub-5267056163100832/8575852612";
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
     
     public void Start()
     {
         RequestInterstitial();  
     }
     
     void Update()
     {
          if (GameManager.showInterstitialAd)
        {
            if (!hasShownAdOneTime)
            {
                hasShownAdOneTime = true;
                Invoke("showInterstitialAd", 3.0f);
            }
        }
     }

     public void showInterstitialAd()
     {
         //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();

            //Stop Sound
            //

            Debug.Log("SHOW AD XXX");
        }
     }
}
