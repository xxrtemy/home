using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secret_Door : MonoBehaviour
{
    public GameObject Door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(Door);
        }
    }
}
