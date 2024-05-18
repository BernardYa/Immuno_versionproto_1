using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeBala : MonoBehaviour
{
    [SerializeField] private Transform controldeDisparo;
    [SerializeField] private GameObject Bala;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Disparo
            Disparar();
        }
    }

    private void Disparar()
    {
        Instantiate(Bala, controldeDisparo.position, controldeDisparo.rotation);
    }
}
