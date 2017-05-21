using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    [SerializeField]
    [Range(0, 10)]
    private float Speed = 1;

    private Transform oldpos;
    public GameObject child1; 
    void Start()
    {
        oldpos = transform;
        StartCoroutine(MakeMove());
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Input.mousePosition;
            if (mousePos.x < Screen.width / 2)
            {
                transform.Rotate(Vector3.forward * 90);
            }
            if (mousePos.x > Screen.width / 2)
            {
                transform.Rotate(Vector3.back * 90);
            }
        }
    }

    IEnumerator MakeMove()
    {
        while (true)
        {
            transform.Translate(Vector3.up);
            yield return new WaitForSeconds(1 / Speed);
            child1.transform.position = oldpos.position;
            oldpos = transform;
        }
    }

    public void KillSnake()
    {
        GameObject.Destroy(this);
    }
}
