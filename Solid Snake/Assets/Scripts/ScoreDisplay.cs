using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private Text DisplayScore;

    void FixedUpdate()
    {
        DisplayScore.text = "SCORE : "+ Points.amaunt;
    }

}
