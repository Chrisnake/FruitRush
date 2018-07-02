using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public int Score;

    void Start()
    {
        Score = 0;
    }

    public void updateScore(int newScore) //Update the score when this method is called
    {
        Score += newScore;
    }

	void FixedUpdate()
	{
        scoreText.text = Score.ToString();
	}
}
