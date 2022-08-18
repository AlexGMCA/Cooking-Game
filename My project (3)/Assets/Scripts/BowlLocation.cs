using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BowlLocation : MonoBehaviour
{
    public GameObject Bowl;
    public GameObject Whisk;
    public GameObject AnimBowl;
    public Transform Bowlloc;
    public Transform AnimBowlLoc;
    float time = 1;
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        time = time + 1;
        AnimBowlLoc.position = Bowlloc.position;

        if(time > 500)
        {
            Whisk.SetActive(true);
            Bowl.SetActive(true);
            AnimBowl.SetActive(false);
        }
    }

}
