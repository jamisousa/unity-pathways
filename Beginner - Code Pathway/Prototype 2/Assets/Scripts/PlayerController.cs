using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float zRange = 3.0f;

    public GameObject projectible;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Method to fire a projectile
    public void FireProjectile()
    {
        if (projectible != null)
        {
            Instantiate(projectible, transform.position, projectible.transform.rotation);
        }
        else
        {
            Debug.LogWarning("");
        }
    }


    // Update is called once per frame
    void Update()
    {
        // Get axis
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Move player x and z
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        // Map boundaries
        float x = Mathf.Clamp(transform.position.x, -xRange, xRange);
        float z = Mathf.Clamp(transform.position.z, -zRange, zRange);
        transform.position = new Vector3(x, transform.position.y, z);

        // Fire projectile when space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }
    }

}
