using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;

    public void Jugar()
    {
        Scene.Manager.LoadScene(Scene.Manager.GetActiveScene().buildIndex + 1);

        public void OpenOptions()
        {
            mainMenu.SetActive(false);
            optionsMenu.SetActive(true);
        }


        public void salir()
        {
            Debug.log(¨Salir¨);
            Application.Quit();
        }

    }
}