using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseTest : MonoBehaviour
{

    // Use this for initialization
    public bool Adfree;
    void Start()
    {
        Adfree = Convert.ToBoolean(PlayerPrefs.GetInt("Adfree"));

    }

    // Update is called once per frame
    void Update()
    {
        print("ADFREE" + Adfree);
    }
    public void makePurchase()
    {
        Adfree = true;
        PlayerPrefs.SetInt("Adfree", Convert.ToInt32(Adfree));
        print("VALOR PURCHASED" + Adfree);
    }
}
