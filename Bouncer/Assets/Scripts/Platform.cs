using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Rigidbody2D rb2d;
    public GameManager gm;
    public int platformSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HELLO");
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gm.playerHasDied)
        {
            rb2d.velocity = new Vector2(-platformSpeed, 0.0f);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gm.addScore();
        }
    }
}
