using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoRotacion : MonoBehaviour
{
    private float velocidad = 3f;
    private float velocidadRotacion = 720f;
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
        transform.Translate(movimineto * (velocidad * Time.deltaTime), Space.World);

        if (movimineto != Vector2.zero)
        {
            angulo = Mathf.Atan2(movimineto.y, movimineto.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, angulo), velocidadRotacion * Time.deltaTime);
        }
    }
}