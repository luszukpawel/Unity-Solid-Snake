using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // create instance of gamemanager to get access project-wide
    private static GameManager _instance;

    [SerializeField] private Text Counter;

    public bool isGameStarted = false;

    public static GameManager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        GlobalVariables.Reset();
    }

    public GameObject GameOverPanel;

    // Start game counter
    public IEnumerator StartGame()
    {
        int pom = 3;
        for (int i = pom; i > 0; i--)
        {
            Counter.text = i + "";
            yield return new WaitForSeconds(1f);

        }
        Counter.text = "Go";
        yield return new WaitForSeconds(0.5f);
        isGameStarted = true;
        Counter.text = "";

    }

    // shows game over panel and play game over sound 
    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        SoundManager.Instance.PlayGameOverSound();
    }

}
