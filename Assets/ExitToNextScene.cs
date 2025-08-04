using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToNextScene : MonoBehaviour
{
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (other.CompareTag("Player"))
                SceneManager.LoadScene(2);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (other.CompareTag("Player"))
                SceneManager.LoadScene(3);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (other.CompareTag("Player"))
                SceneManager.LoadScene(4);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (other.CompareTag("Player"))
                SceneManager.LoadScene(0);
        }
    }
}
