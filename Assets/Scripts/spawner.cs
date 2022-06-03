using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject _objecttospawn;
    [SerializeField] private GameObject _spawnPoint;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_objecttospawn, _spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
