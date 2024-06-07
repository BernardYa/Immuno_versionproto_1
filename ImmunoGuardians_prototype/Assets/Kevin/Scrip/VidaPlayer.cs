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
            Destroy(gameObject);
        }
    }
}
