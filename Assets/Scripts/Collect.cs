using UnityEngine;

public class Collect : MonoBehaviour
{
    public int maxLoot = 4;
    public LootSlider lootBar;

    void Start()
<<<<<<< Updated upstream
    {
        
        lootBar.SetMaxLoot(maxLoot);
    }


    
    
     void OnTriggerEnter2D(Collider2D other)
     {
         if (other.tag == ("Player"))
         {
             //Debug.Log("Collected");
             GetLoot(1);

            Destroy(gameObject);
         }
     }
    

    void GetLoot(int Loot)
    {
=======
    {
        
        lootBar.SetMaxLoot(maxLoot);
    }


    
    
     void OnTriggerEnter2D(Collider2D other)
     {
         if (other.tag == ("Player"))
         {
             //Debug.Log("Collected");
             GetLoot(1);

            Destroy(gameObject);
         }
     }
    

    void GetLoot(int Loot)
    {
<<<<<<< HEAD
=======

        
>>>>>>> Stashed changes
>>>>>>> main
        lootBar.SetLoot(1);
    }
}
