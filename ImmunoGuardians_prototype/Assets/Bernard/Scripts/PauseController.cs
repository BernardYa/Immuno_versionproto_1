using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public bool pause;
    public GameObject PantallaPausa;


       void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pause();
        }
    }

    public void Pause()
    {
        pause = !pause;
        PantallaPausa.SetActive(pause);
        if(pause)
        {
            Time.timeScale = 0;

        }
        else
        {
            Time.timescale = 1;
        }
    }
}
