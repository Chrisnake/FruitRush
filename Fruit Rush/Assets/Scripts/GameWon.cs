using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWon : MonoBehaviour {

    public GameObject gameWonPanel;
    public GameObject finalScore;
    public GameObject gamestateText;
    public GameObject buttonState;

    void Start()
    {
        gameWonPanel.SetActive(false);
        finalScore.SetActive(false);
        gamestateText.SetActive(false);
        buttonState.SetActive(false);
    }

    public void Show()
    {
        gameWonPanel.SetActive(true);
        finalScore.SetActive(true);
        gamestateText.gameObject.SetActive(true);
        buttonState.SetActive(true);
    }
}

