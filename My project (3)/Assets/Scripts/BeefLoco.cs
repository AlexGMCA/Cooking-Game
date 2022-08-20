using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeefLoco : MonoBehaviour
{
    //Getting location of Bowl so that when the beef is marinated and is taken out of the bowl.
    public Transform BLoco;
    public Transform LocoB;
    public BowlSpriteSwap BowlSpriteSwap;

    void Update()
    {
        //Making Beef position the same as the bowl's location.
        if(BowlSpriteSwap.doubleclicked == 3)
        {
        BLoco.position = LocoB.position;
        BowlSpriteSwap.doubleclicked = 4;
        }
    }
}
