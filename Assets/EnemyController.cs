using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyController : MonoBehaviour
{
    [SerializeField] Transform[] PatrolPosition;
    [SerializeField] int Patrol_Position_index;

    private NavMeshAgent _agent;

    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>(); 
    }
    void Start()
    {
        _agent.destination = PatrolPosition[Patrol_Position_index].position;
    }
    void Update()
    {
        if (!_agent.pathPending && _agent.remainingDistance < _agent.stoppingDistance + 0.25f) 
        {
            Patrol_Position_index = (Patrol_Position_index + 1) % PatrolPosition.Length;
            _agent.destination = PatrolPosition[Patrol_Position_index].position; 
        }
    }
}
