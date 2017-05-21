using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

    public void StartGame()
    {
        StartCoroutine(StartWithSound("GameScene"));
    }

    public void BackToMenu()
    {
        StartCoroutine(StartWithSound("MainMenu"));
    }

    IEnumerator StartWithSound(string scene)
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }

}
