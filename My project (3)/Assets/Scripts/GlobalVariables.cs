using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    //Creating variables which will be used through the project.
    // This one is to check if an object is cuttable.
    public bool cuttable = false;
    // This one is to check if the scene is at the cooking area.
    public bool InStove = false;
    // This one is to check if the scene is at the deafault area.
    public bool InDefault = true;
    // This one is to check if the cutting area is activated.
    public bool AtBoard = false;
    // This one is to check if the bowl is empty.
    public bool EmptyBowl = true;
    // This one is to check if the bowl has Balsamic vinegar in it.
    public bool BalsamicVinegar = false;
    // This one is to check if the bowl has olive oil in it. 
    public bool OliveOil = false;
    // This one is to check if the bowl has lemon juice in it.
    public bool LemonJuice = false;
    // This one is to check if the bowl has thyme in it.
    public bool Thyme = false;
    // This one is to check if the bowl has salt and pepper in it.
    public bool SaltAndPepper = false;
    // This one is to check if the bowl has been whisked.
    public bool Whisked = false;
    // This one is to check if the bowl is in the fridge.
    public bool InFridge = false;
    // This one is for the timer.
    public int hours = 1;
    // This one is to check if the beef is marinated;
    public bool Marinated = false;
    // This one is to check if the scene is at the fridge.
    public bool AtFridge = false;
    // This one is to check if the beef is in the pan.
    public bool BeefInPan = false;
    // This one is to check if the element is on.
    public bool Cooking = false;
    // This one is to check if the beef is cooked.
    public bool Cooked = false;
    // This one is to check if the beef is on the board.
    public bool BeefOnBoard = false;
}
