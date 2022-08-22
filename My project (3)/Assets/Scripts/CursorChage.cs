using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorChage : MonoBehaviour
{
    //Calling Global Variables
    public GlobalVariables GlobalVariables;
    public Texture2D Knife;
    public Texture2D Normal;

    // Update is called once per frame
    void Update()
    {
    //Setting Cursor as a knife when in cutting mode.
    if(GlobalVariables.AtBoard == true){
    Cursor.SetCursor(Knife, Vector2.zero, CursorMode.ForceSoftware);
    }
    //resets cursor.
    
    if(GlobalVariables.AtBoard == false)
    {
        Cursor.SetCursor(Normal, Vector2.zero, CursorMode.ForceSoftware);
    }
    }
}
