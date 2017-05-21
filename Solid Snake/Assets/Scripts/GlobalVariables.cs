using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables
{
    public static int Points;
    public static int ElementsToAdd;
    public static int BoardX = 10;
    public static int BoardyY = 15;
    public static bool isFood = false;
    public static bool isSpecialFood = false;
    public static bool isPickedEffect = false;

    // reset of variables is necessary when reload
    public static void Reset()
    {
        Points = 0;
        ElementsToAdd = 0;

        isFood = false;
        isSpecialFood = false;
        isPickedEffect = false;
    }


}




