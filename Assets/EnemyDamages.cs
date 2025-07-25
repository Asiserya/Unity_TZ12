using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyDamages : MonoBehaviour
{
    [SerializeField] private ParticleSystem bloodEffect;
    [SerializeField] private float waitForSecond = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.transform != null)
        {
            if (bloodEffect != null)
            {
                ParticleSystem effect = Instantiate(bloodEffect, other.transform.position, Quaternion.identity);
                effect.Play();
            }

            StartCoroutine(ReloadAfterDelay(waitForSecond));
        }
    }

    private IEnumerator ReloadAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        RestartLevel();
    }

    public void RestartLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
