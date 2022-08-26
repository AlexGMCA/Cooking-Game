using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    //Calling this line.
    public GameObject line;

    //Once the line is clicked it will dissapear.
    public void OnMouseDown()
    {
        line.SetActive(false);
    }

}
