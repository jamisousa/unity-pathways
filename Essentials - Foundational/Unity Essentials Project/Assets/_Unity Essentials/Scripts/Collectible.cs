using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{


    public float rotationSpeed;

    public GameObject onCollectEffect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add logic for when the player collects the item, e.g., increase score.


            //Instantiate the effect at the collectible's position and rotation.
            Instantiate(onCollectEffect, transform.position, transform.rotation);

            Debug.Log("Collectible collected!");
            Destroy(gameObject); // Destroy the collectible after collection.

       
        }
    }




}
