using System.Collections;
using UnityEngine;
using UnityEngine.AI;


public class NPCTuna : NPC
{
    public GameObject NPCTunaPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            destination = NPCTunaPrefab.transform.position;
            walk = true;
            GetComponent<SphereCollider>().enabled = false;
        }
    }
    private void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (walk)
        {
            Move();
        }
    }

    protected override void Move()
    {
        navAgent.destination = destination;
    }
}