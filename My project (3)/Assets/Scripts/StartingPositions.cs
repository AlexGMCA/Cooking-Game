using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startingpositions : MonoBehaviour
{
    public Transform Rbutton;
    public Transform Lbutton;
    void Start()
    {
        Rbutton.position = new Vector2(1810, 550);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
