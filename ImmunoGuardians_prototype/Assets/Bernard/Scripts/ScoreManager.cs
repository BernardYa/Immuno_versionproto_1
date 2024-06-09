using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public GameObject victoryPanel; // Añadir la referencia al panel de victoria
    public AudioClip victorySound; // Añadir la referencia al sonido de victoria
    private AudioSource audioSource;
    private int score = 0;
    private int targetScore = 1000; // Puntaje objetivo para ganar

    void Awake()
    {
        // Singleton pattern
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        UpdateScoreText();
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(false); // Asegúrate de que el panel esté desactivado al inicio
        }
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();

        if (score >= targetScore)
        {
            Victory();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void Victory()
    {
        Debug.Log("Victory method called"); // Para depuración
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(true); // Muestra el panel de victoria
        }
        PlayVictorySound();
        Time.timeScale = 0f; // Pausa el juego
    }

    void PlayVictorySound()
    {
        if (audioSource != null && victorySound != null)
        {
            audioSource.PlayOneShot(victorySound);
        }
    }
}