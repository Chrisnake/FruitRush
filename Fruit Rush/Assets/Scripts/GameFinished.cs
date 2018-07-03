using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinished : MonoBehaviour {

    public GameObject gameoverPanel;
    public GameObject finalScore;
    public GameObject gameOverText;
    public GameObject replayButton;

	// Use this for initialization
	void Start () 
    {
        gameoverPanel.SetActive(false);
        finalScore.SetActive(false);
        gameOverText.SetActive(false);
        replayButton.SetActive(false);
	}

    public void GameOver()
    {
        gameoverPanel.SetActive(true);
        finalScore.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        replayButton.gameObject.SetActive(true);
    }
}
