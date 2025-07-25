using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    private Transform player;

    [SerializeField] private ParticleSystem particleEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            ParticleSystem effect = Instantiate(particleEffect, transform.position, Quaternion.identity);
            effect.Play();

            player.transform.position = effect.transform.position;
        }
    }
}
