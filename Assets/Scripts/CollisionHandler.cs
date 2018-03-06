using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In seconds")][SerializeField] float levelLoadDelay = 2f;
    [Tooltip("FX prefab on Player Ship")][SerializeField] GameObject explosion;

    // Use this for initialization
    void Start ()
    {    

    }

    private void OnTriggerEnter(Collider other)
    {
        explosion.SetActive(true);
        SendMessage("OnPlayerDeath");
        Invoke("ReloadLevel", levelLoadDelay);
    }
    
    private void ReloadLevel() //string referenced
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
