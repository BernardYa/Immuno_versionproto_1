using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Disparocargadosonido : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isPlaying = false;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Sustituye "Fire1" por el botón que estés utilizando
        {
            if (!isPlaying)
            {
                PlaySound();
            }
        }

        if (Input.GetButtonUp("Fire1")) // Detecta cuando el botón es soltado
        {
            StopSound();
        }
    }

    void PlaySound()
    {
        audioSource.Play();
        isPlaying = true;
    }

    void StopSound()
    {
        audioSource.Stop();
        isPlaying = false;
    }
}
