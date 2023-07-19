using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public String gameObjectTag;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == gameObjectTag)
        {
            Destroy(other.gameObject);
        }
    }
}
