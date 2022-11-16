using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootSlider : MonoBehaviour
{
    public Slider slider;

<<<<<<< HEAD
=======
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
>>>>>>> main
    public void SetMaxLoot(int loot)
    {
        slider.maxValue = loot;
        slider.value = loot;
<<<<<<< HEAD

=======
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
>>>>>>> main
    }
    public void SetLoot(int loot)
    {
        slider.value -= loot;
<<<<<<< HEAD
        
=======
<<<<<<< Updated upstream
        
=======
>>>>>>> Stashed changes
>>>>>>> main
    }
}
