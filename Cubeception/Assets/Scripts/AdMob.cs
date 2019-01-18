using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMob : MonoBehaviour
{

    private BannerView bannerView;
    private InterstitialAd interstitial;
    // Start is called before the first frame update
    void Start()
    {
        string appId = "ca-app-pub-5267056163100832~2192538982";
        MobileAds.Initialize(appId);
        this.RequestBanner();

        if (this.interstitial.IsLoaded()) {
        this.interstitial.Show();
         }
    }

    private void RequestBanner()
    {
        #if UNITY_ANDROID
      string adUnitId = "ca-app-pub-5267056163100832/7429334045";
        #elif UNITY_IPHONE
      string adUnitId = "";
        #else
      string adUnitId = "unexpected_platform";
        #endif
        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder()
        //.AddTestDevice("E3A02A722AB404CB395263041F75D461")
        .Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
    }
    private void RequestIntersitial()
    {
        #if UNITY_ANDROID
      string adUnitId = "ca-app-pub-5267056163100832/8575852612";
        #elif UNITY_IPHONE
      string adUnitId = "";
        #else
      string adUnitId = "unexpected_platform";
        #endif
          // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);

    }
    void Update()
    {
    }

}
