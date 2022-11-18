
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LootSlider : MonoBehaviour
{
    public Slider slider;
    public Animator anmi;
    public GameObject light;


    void Update()
    {
        if (slider.value <= 0)
        {
            anmi.SetTrigger("Open");
            Debug.Log("open");
            light.SetActive(true);
        }
    }
    public void SetMaxLoot(float loot)
    {
        slider.maxValue = loot;
        slider.value = loot;
    }
    public void SetLoot(float loot)
    {
        slider.value -= loot;


    }
}
