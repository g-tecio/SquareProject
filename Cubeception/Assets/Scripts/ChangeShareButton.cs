using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeShareButton : MonoBehaviour
{

    public Button ShareButton;
    public GameObject RestoreButton;
    public Sprite ShareIconAndroid, ShareIconIOS;


    // Use this for initialization
    void Start()
    {
#if UNITY_ANDROID
        RestoreButton.SetActive(false);
        ShareButton.image.rectTransform.sizeDelta = new Vector2(100, 110);
       
        this.gameObject.GetComponent<Image>().sprite = ShareIconAndroid;

#elif UNITY_IPHONE
            RestoreButton.SetActive(true);
            ShareButton.image.rectTransform.sizeDelta = new Vector2(100, 100);
        this.gameObject.GetComponent<Image>().sprite = ShareIconIOS;
#endif
    }

    void Update()
    {

    }
}
