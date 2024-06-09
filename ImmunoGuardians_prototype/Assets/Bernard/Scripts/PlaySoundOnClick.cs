using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySoundOnClick : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al AudioSource

    void Start()
    {
        // Obt�n el componente Button de este objeto
        Button btn = GetComponent<Button>();
        if (btn != null)
        {
            // A�adir el listener para el evento onClick
            btn.onClick.AddListener(PlaySound);
        }
        else
        {
            Debug.LogError("No se encontr� el componente Button en el objeto.");
        }
    }

    void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogError("No se encontr� la referencia al AudioSource.");
        }
    }
}