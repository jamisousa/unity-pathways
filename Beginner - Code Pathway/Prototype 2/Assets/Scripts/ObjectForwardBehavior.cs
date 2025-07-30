using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectForwardBehavior : MonoBehaviour
{

    public float speed = 40.0f; // Speed of the object


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);


    }
}
