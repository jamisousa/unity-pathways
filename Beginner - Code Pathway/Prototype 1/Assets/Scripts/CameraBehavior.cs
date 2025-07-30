using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{

    public GameObject player;// Reference to the player GameObject
    public Vector3 offset; // Offset from the player position

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called after all Update functions have been called
    void LateUpdate()
    {

        //Offset the camera position based on the player's position
        transform.position = player.transform.position + offset;
        
    }
}
