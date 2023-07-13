using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    Rigidbody2D rb2d;
    
    public float jumpForce;
    private bool hasJumped;
    public LayerMask whatIsGround;
    private Collider2D collider2D;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        collider2D = gameObject.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hasJumped = Physics2D.IsTouchingLayers(collider2D, whatIsGround);
        
        if(Input.GetKeyDown(KeyCode.Space)){
            if (hasJumped)
            {
                rb2d.velocity = new Vector2(0.0f, jumpForce);
            }
        }
      

    }
}
