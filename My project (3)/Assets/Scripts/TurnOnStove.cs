using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnStove : MonoBehaviour
{
    //Calling GameObjects for the Stove Knob and Flames and Global Variables.
    public GlobalVariables GlobalVariables;
    public GameObject Dial1;
    public GameObject Dial2;
    public GameObject Activated;

    private void OnMouseDown()
    {
        Dial1.SetActive(false);
        Dial2.SetActive(true);
        Activated.SetActive(true);
    }
}
