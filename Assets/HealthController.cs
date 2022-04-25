using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] float MaxHealth = 100;

    private float _currentHealth;

    public float CurrentHealth { get => _currentHealth; }

    void Start()
    {
        _currentHealth = MaxHealth;
    }

    public void GetDamage(float damage)
    {
        _currentHealth -= damage;
        if (CurrentHealth < 0)
        {
            Debug.Log("Game Over");
        }
    }
    public void GetHealth(float health)
    {
        _currentHealth += health;
        if (CurrentHealth < 0)
        {
            Debug.Log("Game Over");
        }
    }
}