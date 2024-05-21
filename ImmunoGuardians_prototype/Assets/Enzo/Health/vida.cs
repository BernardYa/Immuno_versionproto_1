using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vida : MonoBehaviour
{
    public Image relleno;

    public float vidaActual;

    public float vidaMaxima;

    void Update()
    {
        relleno.fillAmount = vidaActual / vidaMaxima;
    }
}
