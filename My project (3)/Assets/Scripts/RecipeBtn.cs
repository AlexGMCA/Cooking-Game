using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeBtn : MonoBehaviour
{
    //Calling recipe window and exit button.
    public GameObject Recipe;
    public GameObject exit;
    public GameObject X;

    //Onclick acitvate recipe window.
    public void OnClick()
    {
        Recipe.SetActive(true);
        exit.SetActive(true);
        X.SetActive(true);
    }
}
