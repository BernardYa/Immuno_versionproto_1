using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objeto que la c�mara seguir� (tu personaje).
    public float height = 10f; // Altura fija de la c�mara desde el suelo.
    public Vector3 offset; // Desplazamiento relativo a la posici�n del personaje.

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 newPosition = target.position + offset;
            newPosition.y = height; // Mantener la altura fija.
            transform.position = newPosition; // Ajusta la posici�n de la c�mara.
            transform.LookAt(target); // Asegura que la c�mara mire al objetivo
        }
    }
}