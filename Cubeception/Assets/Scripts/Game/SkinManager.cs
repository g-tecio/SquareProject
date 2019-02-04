using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkinManager : MonoBehaviour {


    public GameObject square, circle,triangle, triangle1, triangle2, triangle3,triangle4, lockIcon;


    public Sprite classicSquare, classicTriangle, classicCircle;
    public Sprite neonSquare, neonTriangle, neonCircle;
    public Image UIBackground;
    int randomBackground;
    public bool SkinNeon, SkinNormal;

    public bool SkinOwnedNeon, SkinOwnedNormal;

    private int actualCurrency = 0;
    int priceNeon = 100;

    void Start ()
    {
        //PlayerPrefs.DeleteAll();
        SkinNeon = Convert.ToBoolean(PlayerPrefs.GetInt("SkinNeon"));
        SkinNormal = Convert.ToBoolean(PlayerPrefs.GetInt("SkinNormal"));
        SkinOwnedNeon = Convert.ToBoolean(PlayerPrefs.GetInt("SkinOwnedNeon"));
        priceNeon = PlayerPrefs.GetInt("priceNeon");

        if (SkinNormal == false && SkinNeon == false)
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
      
        if (SkinOwnedNeon == true)
        {
            lockIcon.gameObject.gameObject.SetActive(false);
            priceNeon = 0;
        }
        else
        {
            priceNeon = 100;
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
    }


    public void SkinNormalSelected()
    {
        SkinNormal = true;
        SkinNeon = false;
        PlayerPrefs.SetInt("SkinNeon", Convert.ToInt32(SkinNeon));
        PlayerPrefs.SetInt("SkinNormal", Convert.ToInt32(SkinNormal));

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
       // actualCurrency = GameObject.Find("GameManager").GetComponent<ScoreManager>().saveCurrency;

        if (actualCurrency >= priceNeon)
        {

            actualCurrency = actualCurrency - priceNeon;
            priceNeon = 0;

            PlayerPrefs.SetInt("priceNeon", priceNeon);
            PlayerPrefs.SetInt("Currency", actualCurrency);
            
            lockIcon.gameObject.SetActive(false);

            SkinNeon = true;
            SkinNormal = false;
            PlayerPrefs.SetInt("SkinNeon", Convert.ToInt32(SkinNeon));
            PlayerPrefs.SetInt("SkinNormal", Convert.ToInt32(SkinNormal));

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

    void Update()
    {
        SkinNeon = Convert.ToBoolean(PlayerPrefs.GetInt("SkinNeon"));
        SkinNormal = Convert.ToBoolean(PlayerPrefs.GetInt("SkinNormal"));

        actualCurrency = GameObject.Find("GameManager").GetComponent<ScoreManager>().saveCurrency;
        print("neon " + SkinNeon);
        print("classic " + SkinNormal);
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


}
