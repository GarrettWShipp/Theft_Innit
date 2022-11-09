using UnityEngine;

public class Collect : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log("Collected");

        }
    }
}
