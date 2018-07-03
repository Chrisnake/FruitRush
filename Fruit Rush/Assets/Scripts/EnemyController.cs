using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour 
{
    private GameObject player;
    private Vector3 playerPosition;
    public Rigidbody rb;
    public GameObject enemy;
    private float speed = 4.0f;
    public bool check = false;
    void Start()
    {
        player = GameObject.Find("Player"); //At the start of the game the enemy will locate the player object.
    }

    void Update()
    {
        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) //If the player collides with another object.
    {
        if (other.gameObject.CompareTag("lemon")) //If lemon is picked up, add extra time
        {
            other.gameObject.SetActive(false);
            FindObjectOfType<TimeManager>().AddTime(-10); //Minus 10 seconds to the time left
            FindObjectOfType<ScoreManager>().updateScore(-10);
            increaseEnemy();
        }

        if (other.gameObject.CompareTag("orange")) //if orange is picked up, give the user extra 150 points
        {
            other.gameObject.SetActive(false);
            FindObjectOfType<ScoreManager>().updateScore(-10);
            increaseEnemy();
        }

        if (other.gameObject.CompareTag("watermelon")) //if watermelon is picked up
        {
            other.gameObject.SetActive(false);
            FindObjectOfType<ScoreManager>().updateScore(-10);
            increaseEnemy();
        }

        if (other.gameObject.CompareTag("banana")) //if banana is picked up
        {
            other.gameObject.SetActive(false);
            FindObjectOfType<ScoreManager>().updateScore(-10);
            increaseEnemy();
        }
    }

    void increaseEnemy()
    {
        Vector3 increase = new Vector3(0.5f, 0.5f, 0.5f);
        enemy.transform.localScale += increase;
    }
}
