using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public Slider healthBar;
    public Text scoreText;

    public int playerScore = 0;

    private void OnEnable()
    {
        Player.OnUpdateHealth += UpdateHealthBar;
        Score.OnSendScore += UpdateScore;
    }

    private void OnDisable()
    {
        Player.OnUpdateHealth -= UpdateHealthBar;
        Score.OnSendScore -= UpdateScore;
    }

    private void UpdateHealthBar (int health)
    {
        healthBar.value = health;
    }

    private void UpdateScore (int newPlayerScore)
    {
        playerScore += newPlayerScore;
        scoreText.text = "SCORE: " + playerScore.ToString();
    }
}
