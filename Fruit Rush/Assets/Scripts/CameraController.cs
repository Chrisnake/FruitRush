using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    //Camera found by the value of both transform positions of the camera and the player, and take away the difference.
    //Thus every frame add the offset value. 
	
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate() //LateUpdate is ran for following cameras, ran every frame but runs after all items processed first.
    {
        transform.position = player.transform.position + offset;
    }
}
