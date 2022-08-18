using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseFridge : MonoBehaviour
{
    public GameObject ClosedFridge;
    public GameObject OpenedFridge;
    public GameObject CFButton;
    public GameObject OFButton;

    public void Onclick()
    {
        ClosedFridge.SetActive(true);
        OpenedFridge.SetActive(false);
        CFButton.SetActive(false);
        OFButton.SetActive(true);
    }
}
