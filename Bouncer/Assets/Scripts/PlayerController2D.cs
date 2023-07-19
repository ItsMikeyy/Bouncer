using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float jumpForce;
    public GameManager gm;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.hasStart)
        {
            rb2d.WakeUp();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.velocity = new Vector2(0.0f, jumpForce);
            }
        }
        else
        {
            rb2d.Sleep();
        }


    }
}
