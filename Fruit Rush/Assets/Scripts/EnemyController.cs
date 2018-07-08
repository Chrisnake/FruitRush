using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour 
{
    private GameObject player;
    private Vector3 playerPosition;
    public Rigidbody rb;
    public GameObject enemy;
    public float speed = 4.0f;

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
            enemyLogic(other);
        }
        if (other.gameObject.CompareTag("orange")) //if orange is picked up, give the user extra 150 points
        {
            enemyLogic(other);
        }

        if (other.gameObject.CompareTag("watermelon")) //if watermelon is picked up
        {
            enemyLogic(other);
        }

        if (other.gameObject.CompareTag("banana")) //if banana is picked up
        {
            enemyLogic(other);
        }
    }

    void increaseEnemy()
    {
        Vector3 increase = new Vector3(0.5f, 0.5f, 0.5f);
        enemy.transform.localScale += increase;
    }

    public void stopEnemy()
    {
        speed = 0.0f;
    }

    void enemyLogic(Collider other)
    {
        other.gameObject.SetActive(false);
        FindObjectOfType<ScoreManager>().updateScore(-10);
        FindObjectOfType<GameLost>().Show();
        FindObjectOfType<PlayerMovement>().stopSpeed();
        stopEnemy();
    }
}
