using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float Da�o;

    private void Update()
    {
        transform.Translate(Vector3.right  * velocidad * Time.deltaTime);

    }
    
    //public void AumentarDa�o(int multiplacadorDa�o)
   // {
      //  Da�o += multiplacadorDa�o * Da�o;
    //}
    
    

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<Enemigo>().TomarDa�o(Da�o);
            Destroy(gameObject);

        }
    }
}


