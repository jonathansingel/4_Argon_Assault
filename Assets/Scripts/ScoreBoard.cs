﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    int score;
    Text scoreText;
    
	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
	}
	
    public void addPoints(int points)
    {
        //derp herp the derp

        score = score + points;
        scoreText.text = score.ToString();
    }
}
