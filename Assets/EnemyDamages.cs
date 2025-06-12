using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamages : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (other.CompareTag("Player"))
                SceneManager.LoadScene(1);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (other.CompareTag("Player"))
                SceneManager.LoadScene(2);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (other.CompareTag("Player"))
                SceneManager.LoadScene(3);
        }
    }
}
