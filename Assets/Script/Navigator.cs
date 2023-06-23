using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigator : MonoBehaviour

{
    public Transform player;
    private NavMeshAgent agent;
    public float followRadius = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (agent.enabled && distanceToPlayer <= followRadius)
        {
            agent.destination = player.position;
        }
    }
}