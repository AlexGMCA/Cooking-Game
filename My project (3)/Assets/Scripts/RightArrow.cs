using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightArrow : MonoBehaviour
{   
    //Calling the stove background, ChoppingBoard, Arrows and Global Variables.
    public GameObject Stove;
    public GlobalVariables GlobalVariables;
    public GameObject Board;

    public GameObject LeftArrowImage;

    public GameObject LArrow;

    public GameObject RightArrowImage;

    public GameObject FArrow;
    
    public GameObject FArrowImage;

    void Update()
    {
        if(GlobalVariables.InStove == true || GlobalVariables.AtBoard == true)
        {
            gameObject.SetActive(false);
            RightArrowImage.SetActive(false);
        }
    }

    //Changes background Onclick and activates arrows.
    public void Onclick()
    {
        Stove.SetActive(true);
        GameObject.Find("DefaultBackground").SetActive(false);
        GlobalVariables.InStove = true;
        Board.SetActive(false);
        GlobalVariables.InDefault = false;
        LeftArrowImage.SetActive(true);
        LArrow.SetActive(true);
        FArrow.SetActive(true);
        FArrowImage.SetActive(true);
   }

}
