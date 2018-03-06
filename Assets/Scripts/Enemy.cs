using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject enemyExplosion;
    [SerializeField] Transform parent;
    [SerializeField] int pointsPerHit;

    ScoreBoard scoreBoard;

	// Use this for initialization
	void Start ()
    {
        AddBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void AddBoxCollider()
    {
        BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    private void OnParticleCollision(GameObject other)
    {
        scoreBoard.addPoints(pointsPerHit);

        GameObject explosion = Instantiate(enemyExplosion, transform.position, Quaternion.identity);
        explosion.transform.parent = parent;
        Destroy(gameObject);
    }
}
