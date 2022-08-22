using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightArrow : MonoBehaviour
{   
    //Calling GameObjects and Global Variables.
    public GameObject Stove;
    public GlobalVariables GlobalVariables;
    public GameObject Board;
    public GameObject LeftArrowImage;
    public GameObject LArrow;
    public GameObject RightArrowImage;
    public GameObject FArrow;
    public GameObject FArrowImage;
    public GameObject Knife;
    public GameObject RArrow;
    public GameObject Whisk;
    public Transform whisk;
    public GameObject Plate;
    public Transform plate;
    public GameObject Bowl;
    public Transform bowl;
    public GameObject Pan;
    public Transform pan;
    public GameObject KNife;
    public Transform knife;

    void Update()
    {
        if(GlobalVariables.InStove == true || GlobalVariables.AtBoard == true)
        {
            RArrow.SetActive(false);
            RightArrowImage.SetActive(false);
        }
    }

    //Changes background Onclick and activates arrows.
    public void Onclick()
    {
        if(whisk.position.y < 93)
        {
            Whisk.SetActive(false);
        }
        if(plate.position.y < 93)
        {
            Plate.SetActive(false);
        }
        if(bowl.position.y < 93)
        {
            Bowl.SetActive(false);
        }
        if(pan.position.y < 93)
        {
            Pan.SetActive(false);
        }
        if(knife.position.y < 93)
        {
            KNife.SetActive(false);
        }
        Knife.SetActive(false);
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
