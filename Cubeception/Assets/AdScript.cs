using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;


public class AdScript : MonoBehaviour
{

    private BannerView bannerView;
    // Start is called before the first frame update
    void Start()
    {
        #if UNITY_ANDROID
        string appId = "Q-bixca-app-pub-5267056163100832~2192538982";
        #else
        string appId = "unexpected_platform";
        #endif

        //Initialize the google Mobile ads SDK
        MobileAds.Initialize(appId);
        this.RequestBanner();
    }

   /*  private void RequestBanner()
    {
        #if UNITY_ANDROID
        string adUnitId = "QbixBannerca-app-pub-5267056163100832/7429334045";
        #else
        string adUnitId = "unexpected_platform";
        #endif

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
    } */

    private void RequestBanner()
{
  #if UNITY_ANDROID
      string adUnitId = "ca-app-pub-3940256099942544/6300978111";
  #elif UNITY_IPHONE
      string adUnitId = "ca-app-pub-3940256099942544/2934735716";
  #else
      string adUnitId = "unexpected_platform";
  #endif
 
  // Create a 320x50 banner at the top of the screen.
  bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
  // Create an empty ad request.
  AdRequest request = new AdRequest.Builder().Build();
  // Load the banner with the request.
  bannerView.LoadAd(request);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
