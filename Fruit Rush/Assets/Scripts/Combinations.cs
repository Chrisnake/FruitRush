using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combinations : MonoBehaviour
{
    public Rigidbody rb;
    public ArrayList combinations;
   
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ArrayList combinations = new ArrayList(); //Reset the arraylist at the start of when this is called
        combinations.Add(-1);
        combinations.Add(-1);
        combinations.Add(-1);
    }

    void Update()
    {   
       
    }

    void OnTriggerEnter(Collider other) //If the player collides with another object.
    {
        if (other.gameObject.CompareTag("lemon")) //If lemon is picked up, add extra time
        {
            combinations.Add(1);
            int combo = combinationsCheck(); 
        }

        if (other.gameObject.CompareTag("orange")) //if orange is picked up, give the user extra 150 points
        {
            combinations.Add(2);
        }

        if (other.gameObject.CompareTag("watermelon")) //if watermelon is picked up
        {
            combinations.Add(3);
        }

        if (other.gameObject.CompareTag("banana")) //if banana is picked up, the player gets a boost.
        {
            combinations.Add(4);
        }
    }

    public int combinationsCheck()
    {
        int positionOne = combinations.IndexOf(combinations.Count); //Checks the last element in the arraylist
        int positionTwo = combinations.IndexOf(combinations.Count - 1);
        int positionThree = combinations.IndexOf(combinations.Count - 2);

        if ((positionOne == 1) && (positionTwo == 1) && (positionThree == 1))//Thus there is a combination of three lemons 
        {
            return (1);
        }
        else if((positionOne == 2) && (positionTwo == 2) && (positionThree == 2))
        {
            return (2);
        }
        else if ((positionOne == 3) && (positionTwo == 3) && (positionThree == 3))
        {
            return (3);
        }
        else if ((positionOne == 3) && (positionTwo == 3) && (positionThree == 3))
        {
            return (4);
        }

        return (-1);
    }
}
