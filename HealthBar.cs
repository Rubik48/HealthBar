using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : Bar
{
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HealthChanged += ChangeValue;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= ChangeValue;
    }
}
