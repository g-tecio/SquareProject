using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkinManager : MonoBehaviour {


    public GameObject square, lockIcon2, lockIcon3, circle,triangle, triangle1, triangle2, triangle3,triangle4, lockIcon;


    public Sprite classicSquare, classicTriangle, classicCircle;
    public Sprite neonSquare, neonTriangle, neonCircle;
    public Sprite bowSquare, bowTriangle, bowCircle;
    public Sprite soccerSquare, soccerTriangle, soccerCircle;

    public Image UIBackground;
    int randomBackground;
    public bool SkinNeon, SkinNormal, SkinBow, SkinSoccer;

    public bool SkinOwnedNeon, SkinOwnedNormal, SkinOwnedBow, SkinOwnedSoccer;

    

    private int actualCurrency = 0;
    int priceNeon;

    int priceBow;

    int priceSoccer;

    void Start ()
    {
        //PlayerPrefs.DeleteAll();
        SkinNormal = Convert.ToBoolean(PlayerPrefs.GetInt("SkinNormal"));
        SkinNeon = Convert.ToBoolean(PlayerPrefs.GetInt("SkinNeon"));
        SkinBow = Convert.ToBoolean(PlayerPrefs.GetInt("SkinBow"));
        SkinSoccer = Convert.ToBoolean(PlayerPrefs.GetInt("SkinSoccer"));
        SkinOwnedNeon = Convert.ToBoolean(PlayerPrefs.GetInt("SkinOwnedNeon"));
        SkinOwnedBow = Convert.ToBoolean(PlayerPrefs.GetInt("SkinOwnedBow"));
        SkinOwnedSoccer = Convert.ToBoolean(PlayerPrefs.GetInt("SkinOwnedSoccer"));

        priceNeon = PlayerPrefs.GetInt("priceNeon");
        priceBow = PlayerPrefs.GetInt("priceBow");
        priceSoccer = PlayerPrefs.GetInt("priceSoccer");

        print("CLASSIC: " + SkinNormal);
        print("NEON: " + SkinNormal);
        print("BOWLING: " + SkinBow);
        print("SOCCER: " + SkinSoccer);

        if (SkinNormal == false && SkinNeon == false && SkinBow == false && SkinSoccer == false) 
        {
           ChangeBackground1();
        }

        if (SkinNormal == true)
        {
         ChangeBackground1();
        }

        if (SkinNeon == true)
        {
          ChangeBackground2();
        }

        if (SkinBow == true)
        {
          ChangeBackground3();
        }
      
        if (SkinOwnedNeon == true)
        {
            lockIcon.gameObject.gameObject.SetActive(false);
            priceNeon = 0;
        }
        else
        {
            priceNeon = 0;
        }

        if (SkinOwnedBow == true)
        {
            lockIcon2.gameObject.gameObject.SetActive(false);
            priceBow = 0;
        }
        else
        {
            priceBow = 0;
        }

        if (SkinOwnedSoccer == true)
        {
            lockIcon3.gameObject.gameObject.SetActive(false);
            priceSoccer = 0;
        }
        else
        {
            priceSoccer = 0;
        }

        if (SkinNormal == true)
        {
            //NORMAL SKIN
            classicSquare = Resources.Load<Sprite>("Classic/Earth");
            square.GetComponent<SpriteRenderer>().sprite = classicSquare;

            classicCircle = Resources.Load<Sprite>("Classic/Player");
            circle.GetComponent<SpriteRenderer>().sprite = classicCircle;

            classicTriangle = Resources.Load<Sprite>("Classic/ObsN1");
            triangle4.GetComponent<SpriteRenderer>().sprite = classicTriangle;
            triangle2.GetComponent<SpriteRenderer>().sprite = classicTriangle;
            triangle3.GetComponent<SpriteRenderer>().sprite = classicTriangle;
            triangle1.GetComponent<SpriteRenderer>().sprite = classicTriangle;
            
        }

        if (SkinNeon == true)
        {
            //NEON SKIN
            neonSquare = Resources.Load<Sprite>("Neon/Square");
            square.GetComponent<SpriteRenderer>().sprite = neonSquare;
            square.GetComponent<SpriteRenderer>().color = Color.white;

            neonCircle = Resources.Load<Sprite>("Neon/Circle");
            circle.GetComponent<SpriteRenderer>().sprite = neonCircle;
            circle.GetComponent<SpriteRenderer>().color = Color.white;

            neonTriangle = Resources.Load<Sprite>("Neon/Spike");
            triangle4.GetComponent<SpriteRenderer>().sprite = neonTriangle;
            triangle2.GetComponent<SpriteRenderer>().sprite = neonTriangle;
            triangle3.GetComponent<SpriteRenderer>().sprite = neonTriangle;
            triangle1.GetComponent<SpriteRenderer>().sprite = neonTriangle;
            triangle4.GetComponent<SpriteRenderer>().color = Color.white;
            triangle2.GetComponent<SpriteRenderer>().color = Color.white;
            triangle3.GetComponent<SpriteRenderer>().color = Color.white;
            triangle1.GetComponent<SpriteRenderer>().color = Color.white;
        }
        if (SkinBow == true)
        {
            //Bowling SKIN
            bowSquare = Resources.Load<Sprite>("Bowling/Square");
            square.GetComponent<SpriteRenderer>().sprite = bowSquare;
            square.GetComponent<SpriteRenderer>().color = Color.white;

            bowCircle = Resources.Load<Sprite>("Bowling/Circle");
            circle.GetComponent<SpriteRenderer>().sprite = bowCircle;

            bowTriangle = Resources.Load<Sprite>("Bowling/Spike");
            triangle4.GetComponent<SpriteRenderer>().sprite = bowTriangle;
            triangle2.GetComponent<SpriteRenderer>().sprite = bowTriangle;
            triangle3.GetComponent<SpriteRenderer>().sprite = bowTriangle;
            triangle1.GetComponent<SpriteRenderer>().sprite = bowTriangle;
            triangle4.GetComponent<SpriteRenderer>().color = Color.white;
            triangle2.GetComponent<SpriteRenderer>().color = Color.white;
            triangle3.GetComponent<SpriteRenderer>().color = Color.white;
            triangle1.GetComponent<SpriteRenderer>().color = Color.white;    
        }

        if (SkinSoccer == true)
        {
            //Soccer SKIN
            soccerSquare = Resources.Load<Sprite>("Soccer/Square");
            square.GetComponent<SpriteRenderer>().sprite = soccerSquare;
            square.GetComponent<SpriteRenderer>().color = Color.white;

            soccerCircle = Resources.Load<Sprite>("Soccer/Circle");
            circle.GetComponent<SpriteRenderer>().sprite = soccerCircle;

            soccerTriangle = Resources.Load<Sprite>("Soccer/Spike");
            triangle4.GetComponent<SpriteRenderer>().sprite = soccerTriangle;
            triangle2.GetComponent<SpriteRenderer>().sprite = soccerTriangle;
            triangle3.GetComponent<SpriteRenderer>().sprite = soccerTriangle;
            triangle1.GetComponent<SpriteRenderer>().sprite = soccerTriangle;
            triangle4.GetComponent<SpriteRenderer>().color = Color.white;
            triangle2.GetComponent<SpriteRenderer>().color = Color.white;
            triangle3.GetComponent<SpriteRenderer>().color = Color.white;
            triangle1.GetComponent<SpriteRenderer>().color = Color.white;    
        }
    }


    public void SkinNormalSelected()
    {
            SkinNormal = true;
            SkinNeon = false;
            SkinBow = false;
            SkinSoccer = false;

            PlayerPrefs.SetInt("SkinNeon", Convert.ToInt32(SkinNeon));
            PlayerPrefs.SetInt("SkinNormal", Convert.ToInt32(SkinNormal));
            PlayerPrefs.SetInt("SkinBow", Convert.ToInt32(SkinBow));
            PlayerPrefs.SetInt("SkinSoccer", Convert.ToInt32(SkinSoccer));

            //NORMAL SKIN
            classicSquare = Resources.Load<Sprite>("Classic/Earth");
            square.GetComponent<SpriteRenderer>().sprite = classicSquare;

            classicCircle = Resources.Load<Sprite>("Classic/Player");
            circle.GetComponent<SpriteRenderer>().sprite = classicCircle;

            classicTriangle = Resources.Load<Sprite>("Classic/ObsN1");
            triangle4.GetComponent<SpriteRenderer>().sprite = classicTriangle;
            triangle2.GetComponent<SpriteRenderer>().sprite = classicTriangle;
            triangle3.GetComponent<SpriteRenderer>().sprite = classicTriangle;
            triangle1.GetComponent<SpriteRenderer>().sprite = classicTriangle;
            triangle1.GetComponent<SpriteRenderer>().color = Color.black;
            triangle2.GetComponent<SpriteRenderer>().color = Color.black;
            triangle3.GetComponent<SpriteRenderer>().color = Color.black;
            triangle4.GetComponent<SpriteRenderer>().color = Color.black;
  

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }


    public void SkinValentineSelected()
    {

        SkinNormal = false;
        SkinNeon = true;
        SkinBow = false;
        SkinSoccer= false;
       // actualCurrency = GameObject.Find("GameManager").GetComponent<ScoreManager>().saveCurrency;

        if (actualCurrency >= priceNeon)
        {

            actualCurrency = actualCurrency - priceNeon;
            priceNeon = 0;

            PlayerPrefs.SetInt("priceNeon", priceNeon);
            PlayerPrefs.SetInt("Currency", actualCurrency);
            
            lockIcon.gameObject.SetActive(false);

            
            PlayerPrefs.SetInt("SkinNeon", Convert.ToInt32(SkinNeon));
            PlayerPrefs.SetInt("SkinNormal", Convert.ToInt32(SkinNormal));
            PlayerPrefs.SetInt("SkinBow", Convert.ToInt32(SkinBow));
            PlayerPrefs.SetInt("SkinSoccer", Convert.ToInt32(SkinSoccer));

            SkinOwnedNeon = true;
            PlayerPrefs.SetInt("SkinOwnedNeon", Convert.ToInt32(SkinOwnedNeon));

            //NEON SKIN
            neonSquare = Resources.Load<Sprite>("Neon/Square");
            square.GetComponent<SpriteRenderer>().sprite = neonSquare;
            square.GetComponent<SpriteRenderer>().color = Color.white;

            neonCircle = Resources.Load<Sprite>("Neon/Circle");
            circle.GetComponent<SpriteRenderer>().sprite = neonCircle;

            neonTriangle = Resources.Load<Sprite>("Neon/Spike");
            triangle4.GetComponent<SpriteRenderer>().sprite = neonTriangle;
            triangle2.GetComponent<SpriteRenderer>().sprite = neonTriangle;
            triangle3.GetComponent<SpriteRenderer>().sprite = neonTriangle;
            triangle1.GetComponent<SpriteRenderer>().sprite = neonTriangle;

            triangle1.GetComponent<SpriteRenderer>().color = Color.white;
            triangle2.GetComponent<SpriteRenderer>().color = Color.white;
            triangle3.GetComponent<SpriteRenderer>().color = Color.white;
            triangle4.GetComponent<SpriteRenderer>().color = Color.white;
            //triangle.GetComponent<SpriteRenderer>().sprite = neonTriangle;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            print("You don't have enough currency");
        }

    }

    public void SkinBowSelected()
    {
         // actualCurrency = GameObject.Find("GameManager").GetComponent<ScoreManager>().saveCurrency;

        if (actualCurrency >= priceBow)
        {
            SkinNormal = false;
            SkinNeon = false;
            SkinBow = true;
            SkinSoccer = false;
            actualCurrency = actualCurrency - priceBow;
            priceBow = 0;

            PlayerPrefs.SetInt("priceBow", priceBow);
            PlayerPrefs.SetInt("Currency", actualCurrency);
            
            lockIcon2.gameObject.SetActive(false);

            
            PlayerPrefs.SetInt("SkinNeon", Convert.ToInt32(SkinNeon));
            PlayerPrefs.SetInt("SkinNormal", Convert.ToInt32(SkinNormal));
            PlayerPrefs.SetInt("SkinBow", Convert.ToInt32(SkinBow));
            PlayerPrefs.SetInt("SkinSoccer", Convert.ToInt32(SkinSoccer));

            SkinOwnedBow = true;
            PlayerPrefs.SetInt("SkinOwnedBow", Convert.ToInt32(SkinOwnedBow));

            //Bowling SKIN
            bowSquare = Resources.Load<Sprite>("Bowling/Square");
            square.GetComponent<SpriteRenderer>().sprite = bowSquare;
           // square.GetComponent<SpriteRenderer>().color = Color.white;

            bowCircle = Resources.Load<Sprite>("Bowling/Circle");
            circle.GetComponent<SpriteRenderer>().sprite = bowCircle;

            bowTriangle = Resources.Load<Sprite>("Bowling/Spike");
            triangle4.GetComponent<SpriteRenderer>().sprite = bowTriangle;
            triangle2.GetComponent<SpriteRenderer>().sprite = bowTriangle;
            triangle3.GetComponent<SpriteRenderer>().sprite = bowTriangle;
            triangle1.GetComponent<SpriteRenderer>().sprite = bowTriangle;

            // triangle1.GetComponent<SpriteRenderer>().color = Color.white;
            // triangle2.GetComponent<SpriteRenderer>().color = Color.white;
            // triangle3.GetComponent<SpriteRenderer>().color = Color.white;
            // triangle4.GetComponent<SpriteRenderer>().color = Color.white;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            print("You don't have enough currency");
        }
    }

    public void SkinSoccerSelected()
    {
         // actualCurrency = GameObject.Find("GameManager").GetComponent<ScoreManager>().saveCurrency;

        if (actualCurrency >= priceSoccer)
        {
            SkinNormal = false;
            SkinNeon = false;
            SkinBow = false;
            SkinSoccer = true;
            actualCurrency = actualCurrency - priceSoccer;
            priceSoccer = 0;

            PlayerPrefs.SetInt("priceSoccer", priceSoccer);
            PlayerPrefs.SetInt("Currency", actualCurrency);
            
            lockIcon3.gameObject.SetActive(false);

            
            PlayerPrefs.SetInt("SkinNeon", Convert.ToInt32(SkinNeon));
            PlayerPrefs.SetInt("SkinNormal", Convert.ToInt32(SkinNormal));
            PlayerPrefs.SetInt("SkinBow", Convert.ToInt32(SkinBow));
            PlayerPrefs.SetInt("SkinSoccer", Convert.ToInt32(SkinSoccer));

            SkinOwnedSoccer = true;
            PlayerPrefs.SetInt("SkinOwnedSoccer", Convert.ToInt32(SkinOwnedSoccer));

            //Soccer SKIN
            soccerSquare = Resources.Load<Sprite>("Soccer/Square");
            square.GetComponent<SpriteRenderer>().sprite = soccerSquare;
           // square.GetComponent<SpriteRenderer>().color = Color.white;

            soccerCircle = Resources.Load<Sprite>("Soccer/Circle");
            circle.GetComponent<SpriteRenderer>().sprite = soccerCircle;

            soccerTriangle = Resources.Load<Sprite>("Soccer/Spike");
            triangle4.GetComponent<SpriteRenderer>().sprite = soccerTriangle;
            triangle2.GetComponent<SpriteRenderer>().sprite = soccerTriangle;
            triangle3.GetComponent<SpriteRenderer>().sprite = soccerTriangle;
            triangle1.GetComponent<SpriteRenderer>().sprite = soccerTriangle;

            // triangle1.GetComponent<SpriteRenderer>().color = Color.white;
            // triangle2.GetComponent<SpriteRenderer>().color = Color.white;
            // triangle3.GetComponent<SpriteRenderer>().color = Color.white;
            // triangle4.GetComponent<SpriteRenderer>().color = Color.white;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            print("You don't have enough currency");
        }
    }

    void Update()
    {
        SkinNeon = Convert.ToBoolean(PlayerPrefs.GetInt("SkinNeon"));
        SkinBow = Convert.ToBoolean(PlayerPrefs.GetInt("SkinBow"));
        SkinNormal = Convert.ToBoolean(PlayerPrefs.GetInt("SkinNormal"));
        SkinSoccer = Convert.ToBoolean(PlayerPrefs.GetInt("SkinSoccer"));
        actualCurrency = GameObject.Find("GameManager").GetComponent<ScoreManager>().saveCurrency;
       // print("neon " + SkinNeon);
        // print("classic " + SkinNormal);
        // print("bow " + SkinBow);
    }
     void ChangeBackground1()
    {
        UIBackground = GameObject.Find("PanelBackground").GetComponent<Image>();
        randomBackground = UnityEngine.Random.Range(1, 8);
        switch (randomBackground)
        {
            case 1:
                UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/gradient1");
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
        }
    } 


    void ChangeBackground2()
    {
        UIBackground = GameObject.Find("PanelBackground").GetComponent<Image>();
        UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/gradient8");

    } 

    void ChangeBackground3()
    {
        UIBackground = GameObject.Find("PanelBackground").GetComponent<Image>();
        UIBackground.sprite = Resources.Load<Sprite>("Backgrounds/gradient5");

    } 


}
