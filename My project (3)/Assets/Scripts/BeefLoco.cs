using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeefLoco : MonoBehaviour
{
    //Getting location of Bowl so that when the beef is marinated and is taken out of the bowl it appears next to the bowl. Same thing for the pan when cooked.
    public Transform BLoco;
    public Transform LocoB;
    public Transform PLoco;
    public BowlSpriteSwap BowlSpriteSwap;
    public GlobalVariables GlobalVariables;
    public PanSpriteSwap PanSpriteSwap;

    void Update()
    {
        //Making Beef position the same as the bowl's location.
        if(BowlSpriteSwap.doubleclicked == 3)
        {
        BLoco.position = LocoB.position;
        BowlSpriteSwap.doubleclicked = 4;
        }
        if(GlobalVariables.Cooked == true && PanSpriteSwap.doubleclicked == 3)
        {
            BLoco.position = PLoco.position;
            PanSpriteSwap.doubleclicked = 4;
        }  
    }
}
