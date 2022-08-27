using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeefColourChange : MonoBehaviour
{
    //Calling the different stages of beef, global variables and making the two variables use in this script.
    public GlobalVariables globalVariables;
    public Sprite Beef;
    public Sprite Beef1;
    public Sprite Beef2;
    public Sprite Beef3;
    public Sprite Beef4;
    public Sprite Beef5;
    public int Time = 0;
    public bool flip = false;
    public GameObject Arrow;
    public GameObject Text;
    public bool Flipped = false;

    public void OnMouseDown()
    {
        if(flip == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Beef;
            flip = false;
            Time = 0;
            Flipped = true;
        }
    }

    void Update()
    {
        if(Time > 1000 && Time < 1500 && Flipped == false)
        {
            flip = true;
        }
        //Activating the button to flip the steak.
        if(flip == true)
        {
            Arrow.SetActive(true);
            Text.SetActive(true);
        }
        else{
            Arrow.SetActive(false);
            Text.SetActive(false);   
            }
        //Changes the stage of the beef over time.
        if(globalVariables.Cooking == true && flip == false)
        {
            Time = Time + 1;
        }

        if(Time > 500 && Time < 1000)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Beef1;
        }

        if(Time > 500 && Time < 1000 && Flipped == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Beef3;
        }

        if(Time > 1000 && Time < 1500)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Beef2;
        }

        if(Time > 1000 && Time < 1500 && Flipped == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Beef4;
        }

        if(Time > 1500 && Time < 2000 && Flipped == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Beef5;
            globalVariables.Cooked = true;
            globalVariables.Cooking = false;
        }
    }
}
