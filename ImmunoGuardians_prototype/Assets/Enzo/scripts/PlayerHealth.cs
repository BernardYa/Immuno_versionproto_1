using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar; // Referencia a la barra de vida

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); // Inicializa la barra de vida
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth); // Actualiza la barra de vida

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("The Player has died");
        gameObject.SetActive(false);
        Time.timeScale = 0;
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthBar.SetHealth(currentHealth); // Actualiza la barra de vida
    }
}