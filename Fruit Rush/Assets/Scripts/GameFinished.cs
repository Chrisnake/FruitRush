using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinished : MonoBehaviour {
    
    public GameObject gameoverPanel;
    public GameObject finalScore;
    public GameObject gamestateText;
    public GameObject buttonState;

	void Start () 
    {
        gameoverPanel.SetActive(false);
        finalScore.SetActive(false);
        gamestateText.SetActive(false);
        buttonState.SetActive(false);
	}

    public void GameOver()
    {
        gameoverPanel.SetActive(true);
        finalScore.SetActive(true);
        gamestateText.gameObject.SetActive(true);
        buttonState.gameObject.SetActive(true);
    }

    public void GameWon()
    {
        gameoverPanel.SetActive(true);
        finalScore.SetActive(true);
        gamestateText.gameObject.SetActive(true);
        buttonState.gameObject.SetActive(true);
    }
}
