using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    [SerializeField] private int NormalFoodPoints = 1;
    [SerializeField] private int SpecialFoodPoints = 10;

    void Start()
    {
        if (transform.tag == "SpecialFood") StartCoroutine(SpecialFoodTimeout());
    }
    // on collision with food add points and destroy object
    void OnTriggerEnter()
    {
        if (transform.tag == "Food")
        {
            GlobalVariables.Points += NormalFoodPoints;
            GlobalVariables.isFood = false;
        }
        else
        {
            GlobalVariables.Points += SpecialFoodPoints;
            GlobalVariables.isSpecialFood = false;

        }

        SoundManager.Instance.PlayPickUpClip();
        GlobalVariables.ElementsToAdd++;
        GlobalVariables.isPickedEffect = true;
        Destroy(this.gameObject);
    }

    // special food starts to blink before disappearing
    IEnumerator SpecialFoodTimeout()
    {
        yield return new WaitForSeconds(5f);
        for (int i = 0; i < 10; i++)
        {
            GetComponent<MeshRenderer>().enabled = false;
            yield return new WaitForSeconds(0.3f);
            GetComponent<MeshRenderer>().enabled = true;
            yield return new WaitForSeconds(0.3f);
        }
        yield return null;
        Destroy(this.gameObject);
        GlobalVariables.isSpecialFood = false;

    }
}
