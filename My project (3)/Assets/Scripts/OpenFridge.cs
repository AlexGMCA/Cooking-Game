using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFridge : MonoBehaviour
{
    public GameObject ClosedFridge;
    public GameObject OpenedFridge;
    public GameObject FButton;
    public GameObject Fbutton;

    public void Onclick()
    {
        ClosedFridge.SetActive(false);
        OpenedFridge.SetActive(true);
        FButton.SetActive(false);
        Fbutton.SetActive(true);
    }
}
