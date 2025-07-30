﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(10, 4, 5);
        transform.localScale = Vector3.one * 5f;
        
        Material material = Renderer.material;
        
        material.color = new Color(1f, 1.0f, 0.3f, 1f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
