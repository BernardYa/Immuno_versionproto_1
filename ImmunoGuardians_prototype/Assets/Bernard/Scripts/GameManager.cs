using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject victoryPanel;  // Arrastra tu Panel de Victoria aquí desde el Inspector
    public Text scoreText; // Arrastra el Text UI que muestra el puntaje aquí desde el Inspector
    public int targetScore = 1000; // Puntaje objetivo para ganar

    private int currentScore = 0;

    void Start()
    {
        victoryPanel.SetActive(false); // Asegúrate de que el panel esté desactivado al inicio
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
        StartCoroutine(CloseGameAfterDelay(9f)); // Inicia la corutina para cerrar el juego después de 9 segundos
    }

    IEnumerator CloseGameAfterDelay(float delay)
    {
        yield return new WaitForSecondsRealtime(delay); // Espera 9 segundos en tiempo real
        Application.Quit(); // Cierra el juego
#if UNITY_EDITOR
        // Si estás en el editor de Unity, esto detendrá el modo de juego
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}