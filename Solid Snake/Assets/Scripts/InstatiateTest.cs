using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiateTest : MonoBehaviour
{
    public GameObject obj;
    public int x;
    public int y;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Instantiate(obj, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
    }


}
