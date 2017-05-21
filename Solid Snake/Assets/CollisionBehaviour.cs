using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour
{
   

    void OnTriggerEnter(Collider other)
    {
       // Debug.Log("xd");
        GameManager.Instance.GameOver();
        Destroy(other.transform.gameObject);

    }
}
