using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionBala : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("Destroy", 2f);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
