using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    [SerializeField] AudioClip splashScreenMusic;

    AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(splashScreenMusic);
    }
}
