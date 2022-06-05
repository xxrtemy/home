using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAdd : MonoBehaviour
{

    [SerializeField] ParticleSystem _particleSystem;
    [SerializeField] float Health;
    private HealthController trappedHealthController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            trappedHealthController = other.gameObject.GetComponent<HealthController>();
            trappedHealthController.GetHealth(Health);
            _particleSystem.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
