using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanSpriteSwap : MonoBehaviour
{
    public Sprite BeefPan;
    public GlobalVariables GlobalVariables;
    public GameObject beef;
    public BowlSpriteSwap BowlSpriteSwap;
    public GameObject Parent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == ("Beef") && GlobalVariables.Marinated == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = BeefPan;
            GlobalVariables.BeefInPan = true;
            beef.SetActive(false);
        }

        if(GlobalVariables.BeefInPan == true && collision.gameObject.name == ("CookTop"))
        {
            Parent.SetActive(false);
        }
    }
}
