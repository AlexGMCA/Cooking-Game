using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlSpriteSwap : MonoBehaviour
{
    // Calling Game sprites, the animation and  globalvariables
    public GlobalVariables GlobalVariables;
    public Sprite Bowl2;
    public Sprite Bowl3;
    public Sprite Bowl4;
    public Sprite Bowl5;
    public Sprite Bowl6;
    public GameObject BowlAnim;
    public GameObject Bowl;
    public GameObject Whisk;
    public GameObject beef;
    public Sprite BeefBowl;
    public Transform XBowl;
    public int doubleclicked = 0;

    //On Collison the sprite will change.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Adding Balsamic Vinegar
        if(collision.gameObject.name == ("Balsamic Vinegar") && GlobalVariables.EmptyBowl ==  true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Bowl2;
            GlobalVariables.BalsamicVinegar = true;
            GlobalVariables.EmptyBowl = false;
        }

        //Adding Olive Oil
        if(GlobalVariables.BalsamicVinegar == true && collision.gameObject.name == ("OliveOil"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Bowl3;
            GlobalVariables.OliveOil = true;
            GlobalVariables.BalsamicVinegar = false;
        }

        //Adding Lemon Juice
        if(GlobalVariables.OliveOil == true && collision.gameObject.name == ("Lemon Juice"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Bowl4;
            GlobalVariables.LemonJuice = true;
            GlobalVariables.OliveOil = false;
        }

        //Adding Thyme
        if(GlobalVariables.LemonJuice == true && collision.gameObject.name == ("Thyme"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Bowl5;
            GlobalVariables.Thyme = true;
            GlobalVariables.LemonJuice = false;
        }

        //Adding Salt and Pepper
        if(GlobalVariables.Thyme == true && collision.gameObject.name == ("Salt+Pepper"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Bowl6;
            GlobalVariables.SaltAndPepper = true;
            GlobalVariables.Thyme = false;
        }

        //Activating whisking animation
        if(GlobalVariables.SaltAndPepper == true && collision.gameObject.name == ("Whisk"))
        {
            BowlAnim.SetActive(true);
            Bowl.SetActive(false);
            Whisk.SetActive(false);
            GlobalVariables.Whisked = true;
            GlobalVariables.SaltAndPepper = false;
        }

        //Putting beef in bowl for marination
        if(GlobalVariables.Whisked == true && collision.gameObject.name == ("Beef"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = BeefBowl;
            beef.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        if(GlobalVariables.Marinated == true)
        {
        doubleclicked = doubleclicked + 1;
        }
    }

    void Update()
    {
        if(doubleclicked > 2 && GlobalVariables.Marinated == true && GlobalVariables.BeefInPan == false)
        {
            beef.SetActive(true);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Bowl6;
        }

        //registering that the bowl is in the fridge.
        if(XBowl.position.x > 355 && XBowl.position.x < 680)
        {
            GlobalVariables.AtFridge = true;
        }

        if(XBowl.position.x < 355 || XBowl.position.x > 680)
        {
            GlobalVariables.AtFridge = false;
        }
    }
}
