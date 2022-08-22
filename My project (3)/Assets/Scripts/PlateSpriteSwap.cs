using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateSpriteSwap : MonoBehaviour
{
    //Calling Sprites, game objects and global variables.
    public GlobalVariables GlobalVariables;
    public GameObject Beef;
    public GameObject Salad;
    public GameObject Sauce;
    public Sprite SaladPlate;
    public Sprite BeefPlate;
    public Sprite SaucePlate;
    public GameObject Game;
    public GameObject Congrats;

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        //Checks to see if the game object is the salad and if the plate is empty.
        if(collision.gameObject.name == ("SaladPacket") && GlobalVariables.EmptyPlate == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SaladPlate;
            GlobalVariables.EmptyPlate = false;
            GlobalVariables.SaladOnPlate = true;
        }
        //Checks to see if the object is steak and whether or not its ready to be plated and if the plate has salad on it.
        if(collision.gameObject.name == ("Beef") && GlobalVariables.Cut == true && GlobalVariables.SaladOnPlate == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = BeefPlate;
            Beef.SetActive(false);
            GlobalVariables.SaladOnPlate = false;
            GlobalVariables.SteakOnPlate = true;
        }
        //Checks if you can put sauce on dish.
        if(collision.gameObject.name == ("Bowl") && GlobalVariables.SteakOnPlate == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SaucePlate;
            GlobalVariables.SteakOnPlate = false;
            GlobalVariables.done = true;
        }

    }

    void Update()
    {
        if(GlobalVariables.done == true)
        {
            Game.SetActive(false);
            Congrats.SetActive(true);
        }
    }
}
