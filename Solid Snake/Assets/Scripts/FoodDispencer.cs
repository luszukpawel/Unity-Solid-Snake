using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDispencer : MonoBehaviour
{

    public GameObject Food;
    public GameObject SpecialFood;

    // checks if there is no food on scene and Instantiates new at random location
    void Update()
    {
        if(GlobalVariables.isFood == false)
        {
            Instantiate(Food, new Vector3(Random.Range(1, GlobalVariables.BoardX), Random.Range(1, GlobalVariables.BoardyY), 0),Quaternion.identity);
            GlobalVariables.isFood = true;
        }

        if (GlobalVariables.isSpecialFood == false)
        {
            StartCoroutine(DispenseWithDeley());
        }   
    }
    // Dispenses food with random delay 
    IEnumerator DispenseWithDeley()
    {
        GlobalVariables.isSpecialFood = true;
        yield return new WaitForSeconds(Random.Range(3, 10));
        Instantiate(SpecialFood, new Vector3(Random.Range(1, GlobalVariables.BoardX), Random.Range(1, GlobalVariables.BoardyY), 0), Quaternion.identity);
        
    }


}
