using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeArrow : MonoBehaviour
{
    //Calling Fridge Background, Stove Background and the Global Variables.
    public GameObject Fridge;
    public GameObject Stove;
    public GlobalVariables GlobalVariables;
    public GameObject FArrowImage;
    public GameObject SArrowImage;
    public GameObject SArrow;
    public GameObject FridgeButton;
    public GameObject beef;
    public GameObject BalsamicVinegar;
    public GameObject OliveOil;
    public GameObject LJuice;
    public GameObject bowl;
    public GameObject Thyme;
    public GameObject SaltandPepper;
    public GameObject Salad;

    void Update()
    {
        //Deactivating arrow when in fridge area.
        if(GlobalVariables.InFridge == true)
        {
            gameObject.SetActive(false);
            FArrowImage.SetActive(false);
            SArrow.SetActive(true);
            SArrowImage.SetActive(true);
        }
    }

    //The on click function which will change backgrounds.
    public void OnClick()
    {
        if(GlobalVariables.EmptyBowl == false)
        {
            bowl.SetActive(true);
        }
        Salad.SetActive(true);
        Thyme.SetActive(true);
        SaltandPepper.SetActive(true);
        LJuice.SetActive(true);
        OliveOil.SetActive(true);
        BalsamicVinegar.SetActive(true);
        beef.SetActive(true);
        Fridge.SetActive(true);
        Stove.SetActive(false);
        GlobalVariables.InFridge = true;
        GlobalVariables.InStove = false;
        FridgeButton.SetActive(true);
    }
}
