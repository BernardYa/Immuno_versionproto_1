using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider; // Usaremos un Slider para la barra de vida

    // Método para configurar la salud máxima
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    // Método para configurar la salud actual
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}