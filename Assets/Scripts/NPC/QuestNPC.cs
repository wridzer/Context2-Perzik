using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class QuestNPC : NPC
{
    [SerializeField] private GameObject playerInstance;

    private void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (questComplete)
        {
            //Move();
        }
    }

    protected override void Move()
    {
        navAgent.destination = playerInstance.transform.position;
    }
}
