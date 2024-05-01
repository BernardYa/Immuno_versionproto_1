using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform target;
    private float speed;

    public void SetTarget(Transform player, float enemySpeed)
    {
        target = player;
        speed = enemySpeed;
    }

    void Update()
    {
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;

            // Puedes agregar rotación hacia el jugador si es necesario
            // transform.right = direction;
        }
    }
}