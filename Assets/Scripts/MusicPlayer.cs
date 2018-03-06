using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    [SerializeField] AudioClip splashScreenMusic;

    AudioSource audioSource;

    private void Awake()
    {
        int musicPlayersCount = FindObjectsOfType<MusicPlayer>().Length;
        if (musicPlayersCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(splashScreenMusic);
    }
}
