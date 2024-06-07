using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public int CantidadVida;

    public void TomarDaño(int Daño)
    {
        CantidadVida -= Daño;
        if (CantidadVida <= 0)
        {
            Die();
            Destroy(gameObject);
        }
    }
    void Die()
    {
        Debug.Log("The Player has died");
        gameObject.SetActive(false);
        Time.timeScale = 0;
    }
}
