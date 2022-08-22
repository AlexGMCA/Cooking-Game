using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanSpriteSwap : MonoBehaviour
{
    //Calling Sprites and gameobjects.
    public Sprite BeefPan;
    public GlobalVariables GlobalVariables;
    public GameObject beef;
    public GameObject Parent;
    public GameObject StoveTop;
    public GameObject TopDownPan;
    public int doubleclicked = 0;
    public Sprite Pan;
    public GameObject Beef;
    public Sprite CookedBeef;
    public GameObject PanObject;
    public GameObject Whisk;
    public GameObject Bowl;

    //collision detection
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Detects whether or not its beef.
        if(collision.gameObject.name == ("Beef") && GlobalVariables.Marinated == true && GlobalVariables.Cut == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = BeefPan;
            GlobalVariables.BeefInPan = true;
            beef.SetActive(false);
        }
        //Checks to see if the object can be cooked.
        if(GlobalVariables.BeefInPan == true && collision.gameObject.name == ("CookingTop"))
        {
            Parent.SetActive(false);
            StoveTop.SetActive(true);
            TopDownPan.SetActive(true);
        }
    }
    //This is for seperating the sprites.
    private void OnMouseDown()
    {
        if(GlobalVariables.Cooked == true)
        {
        doubleclicked = doubleclicked + 1;
        }
    }
    //Checks to see if the object has been clicked enough to seperate.
    void Update()
    {
        if(doubleclicked > 2 && GlobalVariables.BeefOnBoard == false && GlobalVariables.Cut == false)
        {
            Beef.SetActive(true);
            GlobalVariables.BeefInPan = false;
            Beef.GetComponent<SpriteRenderer>().sprite = CookedBeef;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Pan;
        }
        //If the beef collides with the board it dissapears.
        if(GlobalVariables.BeefOnBoard == true)
        {
            Beef.SetActive(false);
        }
        //Makes certain object dissapear when scene changes to cutting mode.
        if(GlobalVariables.AtBoard == true)
        {
            PanObject.SetActive(false);
            Bowl.SetActive(false);
            Whisk.SetActive(false);
        }
    }
}
