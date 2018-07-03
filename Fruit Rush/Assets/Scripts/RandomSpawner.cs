using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour 
{
    public GameObject banana, watermelon, orange, lemon;

    public float spawnRate = 2f; //Spawn rate of objects
    private float nextSpawn = 0f;
    float randomX, randomZ; //This needs to be set to max and minimum values of the game board
    int chance; //Ensure there is a random chance that orange is chosen, because I do not want too many oranges showing up.

	// Update is called once per frame
	void Update () 
    {
        if(Time.time > nextSpawn)
        {
            Debug.Log(Time.time.ToString());
            int whatToSpawn = Random.Range(1, 5);
            randomX = Random.Range(-8, 8);
            randomZ = Random.Range(-8, 8);
            Vector3 randomPosition = new Vector3(randomX, 1, randomZ);

            if(whatToSpawn == 3)//If the random value is 3, then go through another check to see if
            {
                chance = Random.Range(1, 4);
                if(chance == 3)
                {
                    Debug.Log(whatToSpawn.ToString());
                    InstantiateSpawn(chance, randomPosition); //Spawn the orange if it is a 3.
                }
            }
            else
            {
                InstantiateSpawn(whatToSpawn, randomPosition);
            }
         }
	 }

    void InstantiateSpawn(int whatToSpawn, Vector3 randomPosition)
    {
        Debug.Log(whatToSpawn.ToString());

        switch (whatToSpawn) //Switch statement that spawns depending no the number of the case.
        {
            case 1:
                Instantiate(banana, randomPosition, Quaternion.identity);
                break;
            case 2:
                Instantiate(watermelon, randomPosition, Quaternion.identity);
                break;
            case 3:
                Instantiate(lemon, randomPosition, Quaternion.identity);
                break;
            case 4:
                Instantiate(orange, randomPosition, Quaternion.identity);
                break;
        }
        nextSpawn = Time.time + spawnRate;
    }
}
