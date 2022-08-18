using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spriteswap : MonoBehaviour
{
    public GlobalVariables GlobalVariables;
    public GameObject Chopping;
    public Sprite BeefBoard;
    public GameObject Beef;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == ("Beef"))
        {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = BeefBoard;
        GlobalVariables.cuttable = true;
        }

        if(GlobalVariables.cuttable == true && collision.gameObject.name == ("Knife"))
        {
            GameObject.Find("DefaultBackground").SetActive(false);
            gameObject.SetActive(false);
            Chopping.SetActive(true);
            GameObject.Find("Knife").SetActive(false);
            GameObject.Find("CookedSpaghetti").SetActive(false);
            GlobalVariables.InDefault = false;
            GameObject.Find("Pan").SetActive(false);
        }
    }

}
