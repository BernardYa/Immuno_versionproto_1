using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Image relleno;
    public float VidaActual;
    public float VidaMaxima;
    void Update()
    {
        relleno.fillAmount = VidaActual / VidaMaxima;

       
    }
    
}
