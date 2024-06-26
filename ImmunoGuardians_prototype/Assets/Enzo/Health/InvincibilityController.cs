using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InvincibilityController : MonoBehaviour
{
    private HealthController _healthController;

    private void Awake()
    {
        _healthController = GetComponent<HealthController>();
    }

    public void StartInvinsibility(float invincibilityDuration)
    {
        StartCoroutine(InvincibilityCoroutine(invincibilityDuration));
    }
    private IEnumerator InvincibilityCoroutine(float invincibilityDuration)
    {
        _healthController.IsInvincible = true;
        yield return new WaitForSeconds(invincibilityDuration);
        _healthController.IsInvincible = false;
    }

    internal void StartInvincibility(float invincibilityDuration)
    {
        throw new NotImplementedException();
    }
}