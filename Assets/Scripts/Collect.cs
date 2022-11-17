using UnityEngine;

public class Collect : MonoBehaviour
{
    public int maxLoot = 4;
    public LootSlider lootBar;

    void Start()

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
        void Door()
        {
            if (maxLoot == 0)
            {
            GameObject.Find("EndLevel").SetActive(false);


            }

        }
    
        void GetLoot(int Loot)
        {

            lootBar.SetLoot(1);
        }
    
}

