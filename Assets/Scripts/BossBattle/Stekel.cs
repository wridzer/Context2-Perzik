using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stekel : MonoBehaviour
{
    private Rigidbody rb;
    private BossBattleManager battleManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        battleManager = transform.parent.GetComponent<BossBattleManager>();
    }

    //on collission, enable rigidbody and count on battle manager
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.other.tag == "Sword")
        {
            rb.constraints = RigidbodyConstraints.None;
            battleManager.StekelHit();
        }
    }
}