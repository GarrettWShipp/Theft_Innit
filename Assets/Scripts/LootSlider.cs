using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootSlider : MonoBehaviour
{
    public Slider slider;
    public Animator anmi;



    public void SetMaxLoot(float loot)
    {
        slider.maxValue = loot;
        slider.value = loot;

        if (loot >= 0)
        {
            anmi.SetTrigger("Open");
        }

    }
    public void SetLoot(float loot)
    {
        slider.value -= loot;
        

    }
}
