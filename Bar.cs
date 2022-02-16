using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _changeRate;

    protected void ChangeValue(float currentValue)
    {
        DOTweenModuleUI.DOValue(_slider, currentValue, _changeRate);
    }
}
