using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSwapSprite : MonoBehaviour
{
    //Calling Variables, Game objects and sprites.
    public GlobalVariables GlobalVariables;
    public GameObject Chopping;
    public Sprite BeefBoard;
    public GameObject Beef;
    public GameObject Parent;


    //Collision detector.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks if the object is beef.
        if(collision.gameObject.name == ("Beef") && GlobalVariables.Cooked == true && GlobalVariables.Cut == false)
        {
        Beef.SetActive(false);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = BeefBoard;
        GlobalVariables.cuttable = true;
        GlobalVariables.BeefOnBoard = true;
        }

        //Transitioning to cutting scene.
        if(GlobalVariables.cuttable == true && collision.gameObject.name == ("Knife"))
        {
            GlobalVariables.AtBoard = true; 
            Chopping.SetActive(true);
            Parent.SetActive(false);
            GlobalVariables.InDefault = false;
            GlobalVariables.cuttable = false;
            GlobalVariables.AtBoard = true;
        }
    }
}
