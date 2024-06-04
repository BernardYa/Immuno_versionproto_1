using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;

    public void StartGame()
    {
        Scene.Manager.LoadScene(Scene.Manager.GetActiveScene().buildIndex + 1);
    }

    public void OpenOptions()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void ExitGame()
    {
        Debug.Log("Juego cerrado");
        Application.Quit();
    }
}
