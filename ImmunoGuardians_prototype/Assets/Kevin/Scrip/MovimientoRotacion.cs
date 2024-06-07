using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoRotacion : MonoBehaviour
{
    [SerializeField] private float velocidad = 3f;
    [SerializeField] private float velocidadRotacion = 720f;
    private float angulo;
    private float horizontal;
    private float vertical;
    private Vector2 movimineto;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        movimineto = new Vector2(horizontal, vertical);
        movimineto.Normalize();

     

        // Mover al jugador en el plano XY (2D)
        transform.Translate(movimineto * (velocidad * Time.deltaTime), Space.World);

        if (movimineto != Vector2.zero)
        {
            // Calcular el ángulo de rotación en 2D
            angulo = Mathf.Atan2(movimineto.y, movimineto.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, angulo), velocidadRotacion * Time.deltaTime);
        }
    }
}