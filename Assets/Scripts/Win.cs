using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            SceneManager.LoadScene("Start Menu");

        }
    }
}
