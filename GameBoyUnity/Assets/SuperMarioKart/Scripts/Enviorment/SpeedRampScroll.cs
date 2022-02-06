using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRampScroll : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed = -0.7f;
    
    void Update()
    {
        float offSetY = Time.time * _scrollSpeed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, offSetY);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
