using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // create instance of gamemanager to get access project-wide
    private static SoundManager _instance;

    public static SoundManager Instance { get { return _instance; } }


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
    }

    [SerializeField] private AudioClip GameOverClip;
    [SerializeField] private AudioClip PickUpClip;
    private AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Snake? Snake!? Snaaaake!
    public void PlayGameOverSound()
    {
        source.PlayOneShot(GameOverClip);
    }

    public void PlayPickUpClip()
    {
        source.PlayOneShot(PickUpClip);

    }

}
