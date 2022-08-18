using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSpriteswap : MonoBehaviour
{
    //Calling Game objects and varibales.
    public GlobalVariables GlobalVariables;
    public GameObject Chopping;
    public Sprite BeefBoard;
    public GameObject Everything;
    
    //Collision detector which checks objects name and whether or not it can be cut.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == ("Beef"))
        {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = BeefBoard;
        GlobalVariables.cuttable = true;
        }

        if(GlobalVariables.cuttable == true && collision.gameObject.name == ("Knife"))
        {
            GlobalVariables.AtBoard = true;
            GlobalVariables.InDefault = false;
            GameObject.Find("DefaultBackground").SetActive(false);
            gameObject.SetActive(false);
            Chopping.SetActive(true);
            Everything.SetActive(false);
        }
    }

}
