using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TMP_Text scoreText;
 

    public void OnGameOver(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = "SCORE: " + score.ToString();  

    }

    public void OnRestart()
    {
        SceneManager.LoadScene(0);
    }
}
