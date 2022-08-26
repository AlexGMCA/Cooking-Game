using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invis : MonoBehaviour
{
    public GlobalVariables GlobalVariables;
    public GameObject Beef;

    // Update is called once per frame
    void Update()
    {
        if(GlobalVariables.SteakOnPlate || GlobalVariables.BeefOnBoard)
        {
            Beef.SetActive(false);
        }    
    }
}
