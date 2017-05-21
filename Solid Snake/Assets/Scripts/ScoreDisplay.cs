using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private Text DisplayScore;

    // shows gained score
    void FixedUpdate()
    {
        DisplayScore.text = "SCORE : "+ GlobalVariables.Points;
    }

}
