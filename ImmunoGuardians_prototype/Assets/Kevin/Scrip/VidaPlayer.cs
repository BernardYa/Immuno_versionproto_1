using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public int CantidadVida;

    public void TomarDa�o(int Da�o)
    {
        CantidadVida -= Da�o;
        if (CantidadVida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
