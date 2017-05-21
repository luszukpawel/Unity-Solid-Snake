using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    [Range(0, 10)]
    private float Speed = 1;

    private Transform oldpos;
    private Transform pom;

    public GameObject TailElement;

    public List<GameObject> SnakeTail;

    void Start()
    {
        oldpos = transform;
        StartCoroutine(MakeMove());
    }

    void Update()
    {
        // get input from user, right screen tap -> rotate right, left screen tap -> rotate left
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
    // Snake movement coroutine 
    IEnumerator MakeMove()
    {
        StartCoroutine(GameManager.Instance.StartGame());
        yield return new WaitForSeconds(3f);
        while (true)
        {

            yield return new WaitForSeconds(1 / Speed);

            if (GlobalVariables.ElementsToAdd > 0)
            {
                GameObject obj = Instantiate(TailElement);
                SnakeTail.Add(obj);
                GlobalVariables.ElementsToAdd--;
            }

            for (int i = SnakeTail.Count - 1; i > 0; i--)
            {
                SnakeTail[i].transform.position = SnakeTail[i - 1].transform.position;
            }
            transform.Translate(Vector3.up);

        }
    }

    // kill snake method
    public void KillSnake()
    {
        foreach (GameObject obj in SnakeTail)
        {
            Destroy(obj);
        }
    }
}
