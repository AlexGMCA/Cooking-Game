using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitRecipe : MonoBehaviour
{
    //Calling Recipe and exit button.
    public GameObject Recipe;
    public GameObject Exit;
    public GameObject X;

    //Deactivating recipe window.
    public void OnClick()
    {
        Recipe.SetActive(false);
        Exit.SetActive(false);
        X.SetActive(false);
    }
}
