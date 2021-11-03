using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    //public Gradient gradient;
    public Image fill;

    public void SetMaxHealt(int health)
    {
        slider.maxValue = health;
        slider.value = 100 - health;

        //fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = 100 - health;

        //fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
