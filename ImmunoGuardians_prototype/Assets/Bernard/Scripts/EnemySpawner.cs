using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;
    public int maxEnemies = 10; // Máximo número de enemigos que deseas spawnear.
    public float spawnRate = 2f; // Tasa de spawn de enemigos.
    public float movementSpeed = 3f; // Velocidad de movimiento del enemigo.

    private float nextSpawnTime = 0f;
    private int currentEnemyCount = 0; // Contador de enemigos spawneados actualmente.

    void Update()
    {
        if (Time.time >= nextSpawnTime && currentEnemyCount < maxEnemies)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        currentEnemyCount++;

        EnemyController enemyController = enemy.GetComponent<EnemyController>();
        if (enemyController != null)
        {
            enemyController.SetTarget(player, movementSpeed);
            
        }
    }

    public void EnemyDefeated()
    {
        currentEnemyCount--;
    }
    
}