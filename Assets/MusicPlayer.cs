using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    [SerializeField] float levelDelay = 8.2f;
    [SerializeField] AudioClip splashScreenMusic;

    AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
       
        StartGameSequence();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void StartGameSequence()
    {
        StopSoundIfAlreadyPlaying();
        audioSource.PlayOneShot(splashScreenMusic);
        Invoke("LoadNextLevel", levelDelay);
    }

    private void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex;

        int totalScenes = SceneManager.sceneCountInBuildSettings;

        if (currentSceneIndex + 1 < totalScenes)
        {
            nextSceneIndex = currentSceneIndex + 1;
        }
        else
        {
            nextSceneIndex = 0;
        }

        SceneManager.LoadScene(nextSceneIndex);
    }

    private void StopSoundIfAlreadyPlaying()
    {
        if (audioSource.isPlaying == true)
        {
            audioSource.Stop();
        }
    }


}
