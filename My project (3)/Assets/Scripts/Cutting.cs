using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutting : MonoBehaviour
{
    //Calling the different cut sprites,
    public Sprite Beef1;
    public Sprite Beef2;
    public Sprite Beef3;
    public Sprite Beef4;
    public GameObject Parent;
    public GameObject facilities;
    public int cuts = 0;

    //Cutting how many cuts.
    private void OnMouseDown()
    {
        cuts = cuts + 1;
    }

    void Update()
    {
        //Changing the beef sprites according to the amount of cuts.
        if(cuts == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = Beef1;
        }
        if(cuts == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = Beef2;
        }
        if(cuts == 3)
        {
            this.GetComponent<SpriteRenderer>().sprite = Beef3;
        }
        if(cuts == 4)
        {
            this.GetComponent<SpriteRenderer>().sprite = Beef4;
            Parent.SetActive(true);
            facilities.SetActive(false);
        }
    }
}
