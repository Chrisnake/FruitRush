using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour 
{
    public float speed;
    private Rigidbody rb;
    private bool Boost;
    public float timeLeft = 5f; //Set the time left to 5 seconds
    public Text livesText;
    private int lives;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lives = 3; //Giving the user 3 lives to begin with.
    }

	void Update()
	{
        livesText.text = lives.ToString();
	}

	void FixedUpdate()
    {
        Movement(speed);

        if (Input.GetKey(KeyCode.Space) && checkBoost()) //If they press space and they have a boost (TRUE) //Here is where I implement the boost
        {
            timeLeft -= Time.deltaTime; //Take away 1 second to the timeleft every second
            boost();
        }

        if (timeLeft < 0) //If the timeleft is zero them  // Here
        {
            Boost = false; // Here
            timeLeft = 5f; //Reset the time back to 5 seconds. // Here
        }
    }

    void Movement(float Speed)
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * Speed);
    }

    void OnTriggerEnter(Collider other) //If the player collides with another object.
    {
        if (other.gameObject.CompareTag("lemon")) //If lemon is picked up, add extra time
        {
            other.gameObject.SetActive(false);
            FindObjectOfType<TimeManager>().AddTime(10); //Add 10 seconds to the time left
            FindObjectOfType<ScoreManager>().updateScore(50);
        }

        if (other.gameObject.CompareTag("orange")) //if orange is picked up, give the user extra 150 points
        {
            other.gameObject.SetActive(false);
            FindObjectOfType<ScoreManager>().updateScore(200);
        }

        if (other.gameObject.CompareTag("watermelon")) //if watermelon is picked up
        {
            other.gameObject.SetActive(false);
            FindObjectOfType<ScoreManager>().updateScore(50);
        }

        if (other.gameObject.CompareTag("banana")) //if banana is picked up
        {
            other.gameObject.SetActive(false);
            FindObjectOfType<ScoreManager>().updateScore(50);
            Boost = true;
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            lives--; //Take away one life from the user.
            if(lives == 0)
            {
                FindObjectOfType<GameFinished>().GameOver();
                speed = 0f;
            }
        }
    }

    void unkillable() //orange: make the player unkillable
    {
        
    }

    void boost() //banana: give the player a boost by pressing space!
    {
          float BoostSpeed = 15;
          Movement(BoostSpeed);
    }

    bool checkBoost()
    {
        if (Boost == true) //If they have a boost return true
        {
            return (true);
        }
        else //If they dont have a boost, return false
        {
            return (false);
        }
    }

    public void stopSpeed()
    {
        speed = 0;
    }
}

