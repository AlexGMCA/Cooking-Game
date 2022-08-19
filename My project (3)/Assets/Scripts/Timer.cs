using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //Calling Different sprites and globalvaribales
    public Sprite First;
    public Sprite Second;
    public Sprite Third;
    public Sprite Fourth;
    public GlobalVariables GlobalVariables;

    //when the timer is clicked the hours variables is plus one
    void OnMouseDown()
    {
        GlobalVariables.hours = GlobalVariables.hours + 1;
    }

    //It checks what hours equals and then changes the sprite accordingly
    void Update()
    {
        if(GlobalVariables.hours == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = First;
        }
        if(GlobalVariables.hours == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Second;
        }
        if(GlobalVariables.hours == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Third;
        }
        if(GlobalVariables.hours == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Fourth;
        }
        if(GlobalVariables.hours == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = First;
        }
        if(GlobalVariables.hours == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Second;
        }
        if(GlobalVariables.hours == 7)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Third;
        }
        if(GlobalVariables.hours == 8)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Fourth;
        }
    }
}
