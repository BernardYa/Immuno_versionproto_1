using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInterfaz : MonoBehaviour
{
    [SerializeField] GameObject canvasNewStart;

    public void NewStart()
    {
        canvasNewStart.SetActive(false);
    }
    [SerializeField] GameObject textoInfo;

    public void Info()
    {
        textoInfo.SetActive(!textoInfo.activeSelf);
    }
}
