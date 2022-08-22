using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invis : MonoBehaviour
{
    public GlobalVariables GlobalVariables;

    // Update is called once per frame
    void Update()
    {
        if(GlobalVariables.SteakOnPlate || GlobalVariables.BeefOnBoard)
        {
            this.gameObject.SetActive(false);
        }    
    }
}
