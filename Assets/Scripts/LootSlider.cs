using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootSlider : MonoBehaviour
{
    public Slider slider;

    public void SetMaxLoot(int loot)
    {
        slider.maxValue = loot;
        slider.value = loot;

    }
    public void SetLoot(int loot)
    {
        slider.value -= loot;
        
    }
}
