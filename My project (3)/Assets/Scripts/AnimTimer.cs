using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTimer : MonoBehaviour
{

    public GameObject TimerAnim;
    public int i = 1;

    // Update is called once per frame
    void Update()
    {
        i = i + 1;

        if(i > 500)
        {
            TimerAnim.SetActive(false);
        }
    }
}
