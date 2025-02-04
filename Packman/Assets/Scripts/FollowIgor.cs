using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowIgor : MonoBehaviour
{
    [SerializeField] private Transform player;
    private NavMeshAgent agent;
    private Vector3 randomDirection;
    private float changeDirection;
    private float minDistance = 3f;
    private float maxDistance = 7f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        ChangeDirection();
        
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= 20f)
        {
            agent.SetDestination(player.position);
        }
        else
        {
            changeDirection -= Time.deltaTime;
            if (changeDirection <= 0)
            {
                ChangeDirection();
            }
            agent.SetDestination(randomDirection + transform.position);
        }
    }
    void ChangeDirection()
    {
        randomDirection = Random.insideUnitSphere * 10f;
        changeDirection = Random.Range(minDistance, maxDistance);
    }
}
