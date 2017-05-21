﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
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
    private AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
     

    }

    public void PlayGameOverSound()
    {
        source.PlayOneShot(GameOverClip);
    }

}
