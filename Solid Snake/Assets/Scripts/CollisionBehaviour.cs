using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour
{
    // GameOver When colliding with tail or border
    void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.GameOver();
        Destroy(other.transform.gameObject);
    }
}
