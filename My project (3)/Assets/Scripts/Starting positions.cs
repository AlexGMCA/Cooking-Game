using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingPositions : MonoBehaviour
{
    public Transform Rbutton;
    public Transform Rimage;
    public Transform Lbutton;
    void Start()
    {
        Rbutton.position = new Vector2(1810f, 550f);
        Rimage.position = new Vector2(1810f, 550f);
    }

    // Update is called once per frame
    void Update()
    {
        Rbutton.position = new Vector2(1810f, 550f);
        Rimage.position = new Vector2(1810f, 550f); 
    }
}
