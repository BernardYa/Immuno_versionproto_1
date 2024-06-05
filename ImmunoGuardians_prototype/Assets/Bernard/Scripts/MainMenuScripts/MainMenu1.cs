using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    public void StartGame()
    {
        // Aseg�rate de haber a�adido la escena del juego en el Build Settings.
        SceneManager.LoadScene("SampleScene"); // Reemplaza "GameScene" con el nombre de tu escena del juego.
    }

    public void OpenOptions()
    {
        // Aqu� puedes abrir el men� de opciones o cambiar a la escena de opciones.
        // Por simplicidad, solo mostramos un mensaje en la consola.
        Debug.Log("Options clicked");
    }

    public void ExitGame()
    {
        // Salir del juego.
        Application.Quit();
        // Nota: Este c�digo solo funciona en el build, no en el editor de Unity.
        Debug.Log("Exit clicked"); // Este mensaje es �til para probar en el editor.
    }
}