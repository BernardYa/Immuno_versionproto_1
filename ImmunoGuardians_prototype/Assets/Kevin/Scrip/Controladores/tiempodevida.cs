using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiempodevida : MonoBehaviour
{
    [SerializeField] private float Tiempodevida;

    private void Start()
    {
        Destroy(gameObject, Tiempodevida);
    }

    
}
