using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseRCup : MonoBehaviour
{
    //Calling Gameobjects.
    public GameObject Opened;
    public GameObject Closed;
    public GameObject CButton;
    public GameObject OButton;
    
    //Onlick function activating different objects.
    public void OnClick()
    {
        Opened.SetActive(false);
        Closed.SetActive(true);
        CButton.SetActive(false);
        OButton.SetActive(true);
    }
}
