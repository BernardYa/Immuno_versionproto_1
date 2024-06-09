using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public PlayerHealth  playerhealt; // Referencia al script de salud del jugador
    public Button playAgainButton;
    public Button exitButton;

    void Start()
    {
        // Asegurarse de que el panel de Game Over esté oculto al inicio
        gameOverPanel.SetActive(false);

        // Agregar listeners a los botones
        playAgainButton.onClick.AddListener(PlayAgain);
        exitButton.onClick.AddListener(ExitGame);
    }

    void Update()
    {
        // Comprobar si la salud del jugador es menor o igual a 0
        if (playerhealt .currentHealth <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // Mostrar el panel de Game Over
        gameOverPanel.SetActive(true);

        // Pausar el juego
        Time.timeScale = 0f;
    }

    void PlayAgain()
    {
        // Reiniciar la escena actual
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        // Salir del juego
        Application.Quit();
        // Solo para pruebas en el Editor (no necesario en producción)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}