using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeefColourChange : MonoBehaviour
{
    public GlobalVariables GlobalVariables;
    public Sprite Beef1;
    public Sprite Beef2;
    public Sprite Beef3;
    public int Time = 0;

    void Update()
    {
        if(GlobalVariables.Cooking == true)
        {
            Time = Time + 1;
        }

        if(Time > 500 && Time < 1000)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Beef1;
        }

        if(Time > 1000 && Time < 1500)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Beef2;
        }

        if(Time > 1500 && Time < 2000)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Beef3;
            GlobalVariables.Cooked = true;
            GlobalVariables.Cooking = false;
        }
    }
}
