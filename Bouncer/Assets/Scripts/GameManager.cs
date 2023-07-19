using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool hasStart = false;
    public bool playerHasDied = false;
    public int score = 0;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hasStart = true;
        }
    }

    public void addScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
