using UnityEngine;

public class CoinEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ParticleSystem effect = Instantiate(particleEffect, transform.position, Quaternion.identity);
            effect.Play();

            gameObject.SetActive(false);
        }
    }
}
