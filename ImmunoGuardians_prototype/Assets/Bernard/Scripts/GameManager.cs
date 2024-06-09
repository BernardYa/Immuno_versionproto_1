using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject victoryPanel;  // Arrastra tu Panel de Victoria aqu� desde el Inspector
    public Text scoreText; // Arrastra el Text UI que muestra el puntaje aqu� desde el Inspector
    public int targetScore = 1000; // Puntaje objetivo para ganar

    private int currentScore = 0;

    void Start()
    {
        victoryPanel.SetActive(false); // Aseg�rate de que el panel est� desactivado al inicio
        UpdateScoreText(); // Actualiza el texto del puntaje al inicio
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore;
    }

    public void AddScore(int score)
    {
        currentScore += score;
        UpdateScoreText();

        if (currentScore >= targetScore)
        {
            Victory();
        }
    }

    void Victory()
    {
        victoryPanel.SetActive(true); // Muestra el panel de victoria
        Time.timeScale = 0f; // Pausa el juego
    }
}