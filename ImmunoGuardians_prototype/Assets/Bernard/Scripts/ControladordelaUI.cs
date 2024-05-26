using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInterfaz : MonoBehaviour
{
    [SerializeField] private GameObject canvasNewStart; // Canvas que contiene la pantalla de nuevo inicio
    [SerializeField] private GameObject textoInfo;      // Texto de informaci�n en la UI

    private void Start()
    {
        // Pausar el juego al inicio
        PausarJuego();

        // Mostrar el canvas de nuevo inicio
        if (canvasNewStart != null)
        {
            canvasNewStart.SetActive(true);
        }
    }

    // M�todo que se llama al hacer clic en el bot�n de inicio
    public void NewStart()
    {
        if (canvasNewStart != null)
        {
            canvasNewStart.SetActive(false);
            ReanudarJuego();
        }
        else
        {
            Debug.LogWarning("canvasNewStart no est� asignado.");
        }
    }

    // M�todo que alterna la visibilidad del texto de informaci�n
    public void Info()
    {
        if (textoInfo != null)
        {
            textoInfo.SetActive(!textoInfo.activeSelf);
        }
        else
        {
            Debug.LogWarning("textoInfo no est� asignado.");
        }
    }

    // M�todo para pausar el juego
    private void PausarJuego()
    {
        Time.timeScale = 0;
    }

    // M�todo para reanudar el juego
    private void ReanudarJuego()
    {
        Time.timeScale = 1;
    }
}
