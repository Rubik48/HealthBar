using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private float _maxHealth = 100;
    private float _minHealth = 0;
    private float _damage = 10;
    private float _regeniration = 10;

    public float CurrentHealth { get; private set; }

    public event UnityAction<float> HealthChanged;

    private void Start()
    {
        CurrentHealth = _maxHealth;
    }

    public void TakeDamage()
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth - _damage, _minHealth, _maxHealth);
        HealthChange?.Invoke(CurrentHealth);
    }

    public void Heal()
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + _regeniration, _minHealth, _maxHealth);
        HealthChange?.Invoke(CurrentHealth);
    }
}
