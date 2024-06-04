using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenOptions()
    {
        // Implementar lógica de opciones
        Debug.Log("Opciones abiertas");
    }

    public void ExitGame()
    {
        Debug.Log("Juego cerrado");
        Application.Quit();
    }
}
