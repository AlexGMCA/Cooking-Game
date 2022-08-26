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
    if(line1.activeSelf == false && line2.activeSelf == false && line3.activeSelf == false && line4.activeSelf == false)
    {
        GlobalVariables.AtBoard = false;
        GlobalVariables.Cut = true;
        GlobalVariables.BeefOnBoard = false;
        CutBoard.SetActive(false);
        parent.SetActive(true);
        Board.GetComponent<SpriteRenderer>().sprite = EmptyBoard;
        Steak.SetActive(true);
        Steak.GetComponent<SpriteRenderer>().sprite = CutBeef;
    }
    }
}
