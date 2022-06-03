using UnityEngine;
using System;

public class HealthController : MonoBehaviour
{
    [SerializeField] float MaxHealth = 100;

    public Action<float> HealthChanged;
    private float _currentHealth;

    public float MaxHealthGetter => MaxHealth;
    public float CurrentHealth  => _currentHealth; 

    void Awake()
    {
        _currentHealth = MaxHealth;
    }

    public void GetDamage(float damage)
    {
        _currentHealth -= damage;
        HealthChanged?.Invoke(_currentHealth);
        if (CurrentHealth < 0)
        {
            Debug.Log("Game Over");
        }
    }
    public void GetHealth(float health)
    {
        _currentHealth += health;
        HealthChanged?.Invoke(_currentHealth);
        if (CurrentHealth < 0)
        {
            Debug.Log("Game Over");
        }
    }
}