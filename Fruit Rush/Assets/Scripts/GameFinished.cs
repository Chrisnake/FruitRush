using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
	
	public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameoverPanel.SetActive(true);
        finalScore.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        replayButton.gameObject.SetActive(true);
    }
}
