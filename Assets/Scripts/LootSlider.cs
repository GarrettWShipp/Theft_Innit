using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootSlider : MonoBehaviour
{
    public Slider slider;

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
    public void SetMaxLoot(int loot)
    {
        slider.maxValue = loot;
        slider.value = loot;
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
    }
    public void SetLoot(int loot)
    {
        slider.value -= loot;
<<<<<<< Updated upstream
        
=======
>>>>>>> Stashed changes
    }
}
