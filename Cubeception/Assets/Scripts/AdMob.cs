using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMob : MonoBehaviour
{

    private BannerView bannerView;
    // Start is called before the first frame update
    void Start()
    {
        string appId = "ca-app-pub-5267056163100832~2192538982";
        MobileAds.Initialize(appId);
        this.RequestBanner();
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
        string adUnitId = "ca-app-pub-5267056163100832/3758586307";
        InterstitialAd interstitial = new InterstitialAd(adUnitId);
        if(interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //RequestBanner();
        RequestIntersitial();
        
    }
}
