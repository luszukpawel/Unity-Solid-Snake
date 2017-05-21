using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    [SerializeField] private int NormalFoodPoints = 1;
    [SerializeField] private int SpecialFoodPoints = 10;
    void OnTriggerEnter()
    {
        if(transform.tag == "Food")
        {
            Points.amaunt += NormalFoodPoints;
        }
        else
        {
            Points.amaunt += SpecialFoodPoints;
        }
       
        Destroy(this.gameObject);
    }
}
