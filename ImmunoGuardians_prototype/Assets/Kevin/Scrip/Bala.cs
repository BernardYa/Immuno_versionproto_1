using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float Daño;

    private void Update()
    {
        transform.Translate(Vector3.right  * velocidad * Time.deltaTime);

    }
    
    //public void AumentarDaño(int multiplacadorDaño)
   // {
      //  Daño += multiplacadorDaño * Daño;
    //}
    
    

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<Enemigo>().TomarDaño(Daño);
            Destroy(gameObject);

        }
    }
}


