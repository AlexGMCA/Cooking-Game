using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRCup : MonoBehaviour
{
    //Calling Gameobjects.
    public GameObject Opened;
    public GameObject Closed;
    public GameObject CButton;
    public GameObject OButton;

    //Onlick function activating different objects.
    public void OnClick()
    {
        Opened.SetActive(true);
        Closed.SetActive(false);
        CButton.SetActive(true);
        OButton.SetActive(false);
    }
}
