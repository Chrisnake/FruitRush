using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

    public float timeLeft;
    public Text scoreText;
    	
	// Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime; 
        scoreText.text = timeLeft.ToString("0");
        if (timeLeft < 0)
        {
            FindObjectOfType<GameFinished>().GameOver();
            FindObjectOfType<PlayerMovement>().stopSpeed();
            scoreText.text = "0";
        }
    }

    public void AddTime(int extraTime) //When the player picks up a lemon
    {
        timeLeft += extraTime;
    }

    public float getTime()
    {
        return (timeLeft);
    }
}
