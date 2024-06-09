using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEniemi : MonoBehaviour
{
    public Transform controlDisparoEnemi;
    public float distanciaL;
    public LayerMask capaJugado;
    public bool rangoJugador;
    public GameObject BalaEnemigo;
    public float TiempoDisparo;
    public float TiempoUltimoDisparo;
    public float TesperarBala;

    private void Update()
    {
        rangoJugador = Physics2D.Raycast(controlDisparoEnemi.position, transform.right, distanciaL, capaJugado);
        if (rangoJugador)
        {
            if (Time.time > TiempoDisparo + TiempoUltimoDisparo)
            {
                TiempoUltimoDisparo = Time.time;
                Invoke(nameof(Disparar), TesperarBala);
            }
        }

    }
    private void Disparar()
    {
        Instantiate(BalaEnemigo, controlDisparoEnemi.position, controlDisparoEnemi.rotation);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(controlDisparoEnemi.position, controlDisparoEnemi.position + transform.right * distanciaL);
    }

}