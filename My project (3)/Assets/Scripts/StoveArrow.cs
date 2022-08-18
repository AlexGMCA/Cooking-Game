using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveArrow : MonoBehaviour
{
        //Calling the stove background, ChoppingBoard, Arrows and Global Variables.
    public GameObject Stove;
    public GlobalVariables GlobalVariables;
    public GameObject LeftArrowImage;
    public GameObject LArrow;
    public GameObject FArrow;
    public GameObject FArrowImage;
    public GameObject SArrowImage;
    public GameObject SArrow;
    public GameObject OOil;
    public GameObject BVinegar;
    public GameObject LJuice;
    public GameObject Bowl;
    public GameObject Thyme;
    public GameObject SaltandPepper;

    void Update()
    {
        if(GlobalVariables.InStove == true)
        {
            gameObject.SetActive(false);
            SArrowImage.SetActive(false);
        }
        if(GlobalVariables.EmptyBowl == false && GlobalVariables.InFridge == false)
        {
            Bowl.SetActive(false);
        }
    }

    //Changes background Onclick and activates arrows.
    public void Onclick()
    {
        Thyme.SetActive(false);
        SaltandPepper.SetActive(false);
        LJuice.SetActive(false);
        OOil.SetActive(false);
        BVinegar.SetActive(false);
        Stove.SetActive(true);
        GameObject.Find("FridgeArea").SetActive(false);
        GlobalVariables.InStove = true;
        LeftArrowImage.SetActive(true);
        LArrow.SetActive(true);
        FArrow.SetActive(true);
        FArrowImage.SetActive(true);
        GlobalVariables.InFridge = false;
   }

}
