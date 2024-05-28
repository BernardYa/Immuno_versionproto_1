using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objeto que la cámara seguirá (tu personaje).
    public float height = 10f; // Altura fija de la cámara desde el suelo.
    public Vector3 offset; // Desplazamiento relativo a la posición del personaje.

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 newPosition = target.position + offset;
            newPosition.y = height; // Mantener la altura fija.
            transform.position = newPosition; // Ajusta la posición de la cámara.
            transform.LookAt(target); // Asegura que la cámara mire al objetivo
        }
    }
}