using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrow : MonoBehaviour
{
    //Calling GameObjects and Global Variables.
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
    public GameObject Knife;
    public GameObject Whisk;
    public GameObject Plate;
    public GameObject Bowl;
    public GameObject Pan;
    
    //Making leftarrow dissapear on certain scenes.
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

    //Changes background Onclick and make cetain objects appear and dissapear.
    public void Onclick()
    {
        Pan.SetActive(true);
        if(GlobalVariables.EmptyBowl == true)
        {
        Bowl.SetActive(true);
        }
        Plate.SetActive(true);
        Whisk.SetActive(true);
        Knife.SetActive(true);  
        Stove.SetActive(false);
        DefaultBackground.SetActive(true);
        GlobalVariables.InStove = false;
        Board.SetActive(true);
        GlobalVariables.InDefault = true;
    }
}
