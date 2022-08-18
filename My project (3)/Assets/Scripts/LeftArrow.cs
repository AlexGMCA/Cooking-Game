using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrow : MonoBehaviour
{
    //Calling the Default background, ChoppingBoard, Arrows and Global Variables.
    public GameObject Stove;
    public GlobalVariables GlobalVariables;

    public GameObject DefaultBackground;

    public GameObject Board;

    public GameObject RArrow;

    public GameObject LArrow;

    public GameObject LeftArrowImage;

    public GameObject RightArrowImage;

    public GameObject FArrow;

    public GameObject FArrowImage;

    void Update()
    {
        if(GlobalVariables.InDefault == true || GlobalVariables.AtBoard == true || GlobalVariables.InFridge == true)
        {
        LArrow.SetActive(false);
        LeftArrowImage.SetActive(false);
        }

        if(GlobalVariables.InDefault == true)
        {
            RArrow.SetActive(true);
            RightArrowImage.SetActive(true);
            FArrow.SetActive(false);
            FArrowImage.SetActive(false);
        }
    }

    //Changes background Onclick.
    public void Onclick()
    {
        Stove.SetActive(false);
        DefaultBackground.SetActive(true);
        GlobalVariables.InStove = false;
        Board.SetActive(true);
        GlobalVariables.InDefault = true;
    }
}
