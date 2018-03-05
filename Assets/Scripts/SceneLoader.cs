using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float levelDelay = 8.2f;

    // Use this for initialization
    void Start()
    {
        StartGameSequence();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void StartGameSequence()
    {        
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



}
