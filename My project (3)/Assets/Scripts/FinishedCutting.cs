using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedCutting : MonoBehaviour
{
    //calling all the lines
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject line4;
    public GameObject CutBoard;
    public GameObject parent;
    public GameObject Board;
    public Sprite EmptyBoard;
    public GameObject Steak;
    public Sprite CutBeef;
    public GlobalVariables GlobalVariables;

    void Update()
    {
        //Reactives default background after the cutting is done.
    if(line1.activeSelf == false && line2.activeSelf == false && line3.activeSelf == false && line4.activeSelf == false && GlobalVariables.SteakOnPlate == false)
    {
        GlobalVariables.AtBoard = false;
        GlobalVariables.Cut = true;
        Steak.SetActive(true);
        GlobalVariables.BeefOnBoard = false;
        CutBoard.SetActive(false);
        parent.SetActive(true);
        Board.GetComponent<SpriteRenderer>().sprite = EmptyBoard;
        Steak.GetComponent<SpriteRenderer>().sprite = CutBeef;
    }
}

}

