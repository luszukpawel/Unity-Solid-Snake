using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    [SerializeField] private AudioClip LoadSound;
    public void StartGame()
    {
        StartCoroutine(StartWithSound("GameScene"));
    }

    public void BackToMenu()
    {
        StartCoroutine(StartWithSound("MainMenu"));
    }

    // Starts Scene with sound
    IEnumerator StartWithSound(string scene)
    {
        GetComponent<AudioSource>().PlayOneShot(LoadSound);
        yield return new WaitForSeconds(1.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }

}
