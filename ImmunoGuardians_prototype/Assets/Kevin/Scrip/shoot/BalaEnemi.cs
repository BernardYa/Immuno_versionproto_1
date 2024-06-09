using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemi : MonoBehaviour
{
    public float velocidad;
    public int Daño;


    private void Update()
    {
        transform.Translate(Vector3.right * velocidad * Time.deltaTime);

    }

   



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerHealth  currentHealth))
        {
            currentHealth.TakeDamage(Daño);
            
           
        }
    }
 

}