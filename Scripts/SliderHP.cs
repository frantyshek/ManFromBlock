using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHP : MonoBehaviour
{

    public Slider Slider;

    public void SetHealth(int currentHP, int maxHP)
    {
        Slider.value = currentHP;
        Slider.maxValue = maxHP;
    }
}
