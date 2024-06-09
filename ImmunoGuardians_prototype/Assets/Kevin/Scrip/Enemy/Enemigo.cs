using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private GameObject efectomuerte;
    public int points = 10;

    public void TomarDaño(float Daño)
    {
        vida -= Daño;
        if (vida<=0)
        {
            Muerte();
        }
    }
    private void Muerte()
    {
        Instantiate(efectomuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.AddScore(points);
        }
  
   }

}
