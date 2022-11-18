using UnityEngine;

public class Detected : MonoBehaviour
{
    public PlayerController player;
    public GameObject CageCanvas;
    public GameObject Cage;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log("game over");
            player.speed = 0;
            player.jump = 0;
            CageCanvas.SetActive(true);
            Cage.SetActive(true);
            
        }
    }
}