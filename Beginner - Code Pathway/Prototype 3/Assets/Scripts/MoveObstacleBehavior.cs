using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacleBehavior : MonoBehaviour
{

    private float speed = 30f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();


    }

    // Update is called once per frame
    void Update()
    {

        // Check if the obstacle has moved past a certain point and destroy it
        if(transform.position.x < -25 && CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        }
        ;
    }
}
