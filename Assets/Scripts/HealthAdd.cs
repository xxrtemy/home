using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAdd : MonoBehaviour
{

    [SerializeField] float Health;
    private HealthController trappedHealthController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            trappedHealthController = other.gameObject.GetComponent<HealthController>();
            trappedHealthController.GetHealth(Health);
            Debug.Log(trappedHealthController.CurrentHealth);
        }
        Destroy(gameObject);
    }
}
