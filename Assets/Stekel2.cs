using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stekel2 : MonoBehaviour
{
    private Rigidbody rb;
    private BossBattleManager battleManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        battleManager = transform.parent.transform.parent.transform.parent.transform.parent.transform.parent.transform.parent.transform.parent.transform.parent.transform.parent.transform.parent.GetComponent<BossBattleManager>();
    }

    //on collission, enable rigidbody and count on battle manager
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Sword")
        {
            rb.constraints = RigidbodyConstraints.None;
            battleManager.StekelHit();
            GetComponent<Stekel>().enabled = false;
        }
    }
}