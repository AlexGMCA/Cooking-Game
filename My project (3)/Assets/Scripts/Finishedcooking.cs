using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishedcooking : MonoBehaviour
{
    //Calling GameObjects, Sprites and Global Variables.
    public GameObject Parent;
    public GameObject StoveTop;
    public GlobalVariables GlobalVariables;
    public GameObject Pan;
    public Sprite CookPan;

    void Update()
    {
        //Telling the game that the beef is not cooked and to change scenes.
        if(GlobalVariables.Cooked == true && GlobalVariables.AtBoard == false)
        {
            Parent.SetActive(true);
            StoveTop.SetActive(false);
            Pan.GetComponent<SpriteRenderer>().sprite = CookPan; 
        }
    }
}
